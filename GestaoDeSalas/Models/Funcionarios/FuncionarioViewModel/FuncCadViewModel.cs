using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestaoDeSalas.Models.Funcionarios.FuncionarioViewModel
{
    public class FuncCadViewModel
    {
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }

        public FuncCadViewModel()
        {

        }
    }
}