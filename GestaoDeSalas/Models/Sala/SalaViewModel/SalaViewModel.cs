using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestaoDeSalas.Models.Sala.SalaViewModel
{
    public class SalaViewModel
    {
        public string NomeSala { get; set; }
        public List<Salas> ListaSalas{ get; set; }

        public SalaViewModel()
        {
            this.ListaSalas = new List<Salas>();
        }

        public SalaViewModel(List<Salas> listaSalas)
        {
            this.ListaSalas = new List<Salas>();
            this.ListaSalas = listaSalas;
        }
    }
}