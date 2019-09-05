using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GestaoDeSalas.Models.Funcionarios.FuncionarioViewModel
{
    public class FuncIndexViewModel
    {
        [Display(Name = "Nome ou usuário")]
        public string nome { get; set; }

        public List<Funcionario> ListaFuncionarios{ get; set; }

        public FuncIndexViewModel()
        {

        }

        public FuncIndexViewModel(List<Funcionario> listaFuncionarios)
        {
            this.ListaFuncionarios = listaFuncionarios;
        }
    }
}