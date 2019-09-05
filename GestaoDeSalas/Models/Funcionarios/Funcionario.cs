using GestaoDeSalas.Models.Funcionarios.FuncionarioViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestaoDeSalas.Models.Funcionarios
{
    [Table("Funcionario")]
    public class Funcionario
    {
        public int FuncionarioId { get; set; }

        [Required]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Usuário")]
        public string Usuario { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Senha { get; set; }

        public Funcionario()
        {

        }
        
        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="username"></param>
        /// <param name="senha"></param>
        public Funcionario(string nome, string username, string senha)
        {
            this.Nome = nome;
            this.Usuario = username;
            this.Senha = senha;
        }

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="username"></param>
        /// <param name="senha"></param>
        public Funcionario(FuncCadViewModel model)
        {
            this.Nome = model.Nome;
            this.Usuario = model.Usuario;
            this.Senha = model.Senha;
        }

    }
}