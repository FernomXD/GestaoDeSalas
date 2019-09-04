using GestaoDeSalas.Models.BancoDeDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GestaoDeSalas.Models.Funcionarios;
using System.Data.Entity;
using GestaoDeSalas.Models.Funcionarios.FuncionarioViewModel;

namespace GestaoDeSalas.Controllers.Plataforma
{
    public class AccountController : Controller
    {
        BancoDBContext db = new BancoDBContext();

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(FuncCadViewModel model)
        {
            Funcionario func = new Funcionario(model);

            if (func != default(Funcionario))
            {
                //Criando Cookie
                var cookie = new HttpCookie("_LoginFunc", Guid.NewGuid().ToString());
                cookie.Expires.AddDays(1);
                HttpContext.Response.SetCookie(cookie);

                db.Funcionario.Add(func);

                LoginFuncionario Login = new LoginFuncionario(cookie.Value, func.FuncionarioId);
                db.LoginFuncionario.Add(Login);
                //db.LoginProfissional.Add(Login);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return View();
        }


        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FuncLoginViewModel model)
        {
            //var cookie = (HttpCookie)Request.Cookies[".AspNet.ApplicationCookie"];

            Funcionario func = db.Funcionario.FirstOrDefault(i => i.Usuario == model.Usuario && i.Senha == model.Senha);

            if (func != default(Funcionario))
            {
                //Criando Cookie
                var cookie = new HttpCookie("_LoginFunc", Guid.NewGuid().ToString());
                cookie.Expires.AddDays(1);
                HttpContext.Response.SetCookie(cookie);



                LoginFuncionario Login = new LoginFuncionario(cookie.Value, func.FuncionarioId);
                db.LoginFuncionario.Add(Login);
                //db.LoginProfissional.Add(Login);
                db.SaveChanges();
                return RedirectToAction("Index","Home");
            }

            ViewBag.ErroLogin = "Usuário e/ou senha incorretos";

            return View();
        }

        // GET: LoginProfissional/Create
        public ActionResult logout()
        {

            var cookie = (HttpCookie)Request.Cookies["_LoginFunc"];

            if (cookie != null)
            {
                if (db.LoginFuncionario.FirstOrDefault(i => i.CookieValue == cookie.Value) != null)
                {

                    LoginFuncionario profissionalLogado = db.LoginFuncionario.FirstOrDefault(i => i.CookieValue == cookie.Value);

                    profissionalLogado.LogOut = true;

                    db.Entry(profissionalLogado).State = EntityState.Modified;
                    //db.LoginProfissional.Add(Login);
                    db.SaveChanges();


                    cookie.Expires = DateTime.Now.AddDays(-1);
                    Response.Cookies.Add(cookie);

                }
                else
                {
                    cookie.Expires = DateTime.Now.AddDays(-1);
                    Response.Cookies.Add(cookie);
                }

            }

            return RedirectToAction("Index","Home");
        }
    }
}