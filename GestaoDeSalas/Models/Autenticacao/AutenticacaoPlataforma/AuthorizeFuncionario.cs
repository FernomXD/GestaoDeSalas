using GestaoDeSalas.Models.BancoDeDados;
using GestaoDeSalas.Models.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestaoDeSalas.Models.Autenticacao.AutenticacaoPlataforma
{
    public class AuthorizeFuncionario : AuthorizeAttribute
    {
        /// <summary>
        /// Método responsável por verificar se o cliente está logado utilizando o cookie.
        /// </summary>
        /// <param name="httpContext"></param>
        /// <returns></returns>
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            BancoDBContext db = new BancoDBContext();


            var cookie = httpContext.Request.Cookies["_LoginFunc"];

            if (cookie != null && cookie != default(HttpCookie) && db.LoginFuncionario.FirstOrDefault(i => i.CookieValue == cookie.Value) != null)
            {
                LoginFuncionario login = db.LoginFuncionario.FirstOrDefault(i => i.CookieValue == cookie.Value);

                if (login != null)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
    }
}