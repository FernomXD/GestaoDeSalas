using GestaoDeSalas.Models.BancoDeDados;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestaoDeSalas.Models.Sala
{
    [Table("SalasAgendadas")]
    public class SalasAgendadas
    {
        public int SalasAgendadasId { get; set; }

        [Display(Name = "Sala do agendamento")]
        [ForeignKey("Salas")]
        public int SalasId { get; set; }
        public virtual Salas Salas { get; set; }

        
        [Display(Name = "Título")]
        public string Titulo { get; set; }


        [Required]
        [Display(Name = "Data de início")]
        public DateTime DataInicio { get; set; }

        [Required]
        [Display(Name = "Data de fim")]
        public DateTime DataFim { get; set; }

        public SalasAgendadas()
        {

        }

        /// <summary>
        ///  Construtor que gera um id para a criação da reserva da sala.
        /// </summary>
        /// <param name="salasAgendadasId"></param>
        /// <param name="salaId"></param>
        /// <param name="dataAgendada"></param>
        /// <param name="tempoUsoMinutos"></param>
        public SalasAgendadas(int salaId, DateTime dataInicio, DateTime dataFim, string titulo)
        {
            this.SalasId = salaId;
            this.DataInicio = dataInicio;
            this.DataFim = dataFim;
            this.Titulo = titulo;
        }

        /// <summary>
        ///  Construtor que recebe um id para criação do objeto da reserva da sala.
        /// </summary>
        /// <param name="salasAgendadasId"></param>
        /// <param name="salaId"></param>
        /// <param name="dataAgendada"></param>
        /// <param name="tempoUsoMinutos"></param>
        public SalasAgendadas(int salasAgendadasId, int salaId, DateTime dataInicio, DateTime dataFim, string titulo)
        {
            this.SalasAgendadasId = salasAgendadasId;
            this.SalasId = salaId;
            this.DataInicio = dataInicio;
            this.DataFim = dataFim;
            this.Titulo = titulo;
        }

        public bool VerificaDisponibilidade()
        {
            BancoDBContext db = new BancoDBContext();

            DateTime inicioEvento = this.DataInicio.AddSeconds(1);
            DateTime fimEvento = this.DataFim;


            List<SalasAgendadas> agendamentosConflitantes = db.SalasAgendadas.Where(i => inicioEvento >= i.DataInicio && inicioEvento <= i.DataFim && this.SalasId == i.SalasId).ToList();
            agendamentosConflitantes.AddRange(db.SalasAgendadas.Where(i => fimEvento >= i.DataInicio && fimEvento <= i.DataFim && this.SalasId == i.SalasId).ToList());
            agendamentosConflitantes.AddRange(db.SalasAgendadas.Where(i => inicioEvento <= i.DataInicio && fimEvento >= i.DataFim && this.SalasId == i.SalasId).ToList());

            if (agendamentosConflitantes.Count == 0)
                return true;
            else
                return false;
        }
    }


}