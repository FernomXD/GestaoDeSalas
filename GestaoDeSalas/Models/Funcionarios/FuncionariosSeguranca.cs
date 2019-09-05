using GestaoDeSalas.Models.BancoDeDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestaoDeSalas.Models.Funcionarios
{
    public class FuncionariosSeguranca : Funcionario
    {
        /// <summary>
        /// Método responsável por verificar se o usuário está logado.
        /// </summary>
        /// <param name="username">Usuário do funcionário</param>
        /// <param name="senha">Senha do funcionário</param>
        /// <returns></returns>
        public static bool Login(string username, string senha)
        {
            BancoDBContext db = new BancoDBContext();

            var funcionario = db.Funcionario.FirstOrDefault(i => i.Usuario == username && i.Senha == senha);

            if (funcionario != default(Funcionario))
                return true;
            else
                return false;
        }
    }
}