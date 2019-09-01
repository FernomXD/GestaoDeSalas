using GestaoDeSalas.Models.BancoDeDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestaoDeSalas.Models.Funcionarios
{
    public class FuncionariosSeguranca : Funcionario
    {
        //public static bool Login(string login, string senha)
        //{
        //    using (BancoDBContext entities = new BancoDBContext())
        //    {
        //        return entities.Funcionario.Any(user =>
        //       user.Usuario.Equals(login, StringComparison.OrdinalIgnoreCase)
        //       && user.Senha == senha);
        //    }
        //}

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