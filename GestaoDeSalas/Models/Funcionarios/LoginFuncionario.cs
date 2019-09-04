using GestaoDeSalas.Models.BancoDeDados;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestaoDeSalas.Models.Funcionarios
{
    public class LoginFuncionario
    {
        public Guid LoginFuncionarioId { get; set; }
        public string CookieValue { get; set; }

        [ForeignKey("Funcionario")]
        public int FuncionarioId { get; set; }
        public virtual Funcionario Funcionario { get; set; }


        public DateTime HoraLogin { get; set; }

        public bool LogOut { get; set; }


        public LoginFuncionario()
        {

        }

        public LoginFuncionario(string CookieValueTela, int FuncionarioIdIdTela)
        {
            this.LoginFuncionarioId = Guid.NewGuid();
            this.CookieValue = CookieValueTela;
            this.FuncionarioId = FuncionarioIdIdTela;
            this.HoraLogin = DateTime.Now;
        }

        static public bool VerificaLogado(HttpCookie cookie)
        {
            BancoDBContext db = new BancoDBContext();

            if (cookie != null)
            {
                //Busca um registro que tenha o cookie do usuário.
                LoginFuncionario loginFuncionario = db.LoginFuncionario.FirstOrDefault(i => i.CookieValue == cookie.Value);

                if (loginFuncionario != default(LoginFuncionario))
                    return true;
            }
            return false;
        }

        static public string RetornaNome(HttpCookie cookie)
        {
            BancoDBContext db = new BancoDBContext();

            if (cookie != null)
            {
                //Busca um registro que tenha o cookie do usuário.
                LoginFuncionario loginFuncionario = db.LoginFuncionario.FirstOrDefault(i => i.CookieValue == cookie.Value);

                if (loginFuncionario != default(LoginFuncionario))
                    return loginFuncionario.Funcionario.Nome;
            }
            return "";
        }

    }
}