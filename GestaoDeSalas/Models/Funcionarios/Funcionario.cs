using GestaoDeSalas.Models.Funcionarios.FuncionarioViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestaoDeSalas.Models.Funcionarios
{
    [Table("Funcionario")]
    public class Funcionario
    {
        public int FuncionarioId { get; set; }

        public string Nome { get; set; }

        public string Usuario { get; set; }

        public string Senha { get; set; }

        public Funcionario()
        {

        }

        public Funcionario(string nome, string username, string senha)
        {
            this.Nome = nome;
            this.Usuario = username;
            this.Senha = senha;
        }

        public Funcionario(FuncCadViewModel model)
        {
            this.Nome = model.Nome;
            this.Usuario = model.Usuario;
            this.Senha = model.Senha;
        }

    }
}