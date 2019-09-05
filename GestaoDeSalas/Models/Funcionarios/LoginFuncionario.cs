using GestaoDeSalas.Models.BancoDeDados;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestaoDeSalas.Models.Funcionarios
{
    /// <summary>
    /// Classe que será responsável por guardar as informações de login de todos os usuários
    /// </summary>
    public class LoginFuncionario
    {
        //Id do login
        public Guid LoginFuncionarioId { get; set; }

        //Cookie do login 
        public string CookieValue { get; set; }

        //Funcionário logado
        [ForeignKey("Funcionario")]
        public int FuncionarioId { get; set; }
        public virtual Funcionario Funcionario { get; set; }

        //Hora do login
        public DateTime HoraLogin { get; set; }

        //Boolean para registrar se o funcionário já deslogou.
        public bool LogOut { get; set; }

        /// <summary>
        /// Construtor padrão
        /// </summary>
        public LoginFuncionario()
        {

        }

        /// <summary>
        /// Construtor para criar um objeto de login utilizando um cookie e o id do funcionário
        /// </summary>
        /// <param name="CookieValueTela"></param>
        /// <param name="FuncionarioIdIdTela"></param>
        public LoginFuncionario(string CookieValueTela, int FuncionarioIdIdTela)
        {
            this.LoginFuncionarioId = Guid.NewGuid();
            this.CookieValue = CookieValueTela;
            this.FuncionarioId = FuncionarioIdIdTela;
            this.HoraLogin = DateTime.Now;
        }

        /// <summary>
        /// Verificar por meio do cookie se o funcionário está logado
        /// </summary>
        /// <param name="cookie"></param>
        /// <returns></returns>
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


        //Retorna o nome do funcionário logado.
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