using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestaoDeSalas.Models.Sala.SalaViewModel
{
    public class AgendamentoIndexViewModel
    {
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public string NomeReunião { get; set; }
        public List<SalasAgendadas> Agendamentos{ get; set; }


        public AgendamentoIndexViewModel()
        {
            this.Agendamentos = new List<SalasAgendadas>();
        }


        public AgendamentoIndexViewModel(List<SalasAgendadas> listaSalas, DateTime inicio, DateTime fim)
        {
            this.Agendamentos = new List<SalasAgendadas>();

            this.Agendamentos = listaSalas;

            this.Inicio = inicio;
            this.Fim = fim;
        }
    }
}