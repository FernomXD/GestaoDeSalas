using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestaoDeSalas.Models.Sala
{
    [Table("Salas")]
    public class Salas
    {

        public int SalasId { get; set; }
        [Required]
        [Display(Name = "Nome da sala")]
        public string NomeSala { get; set; }
        [Display(Name = "Descrição da sala")]
        public string DescricaoSala { get; set; }

        public Salas()
        {

        }

        /// <summary>
        /// Construtor que gera um id para criação da sala.
        /// </summary>
        /// <param name="salaId"></param>
        /// <param name="nomeSala"></param>
        /// <param name="descricaoSala"></param>
        public Salas(string nomeSala, string descricaoSala)
        {
            this.NomeSala = nomeSala;
            this.DescricaoSala = descricaoSala;
        }

        /// <summary>
        /// Construtor que recebe um id para criação do objeto sala.
        /// </summary>
        /// <param name="salaId"></param>
        /// <param name="nomeSala"></param>
        /// <param name="descricaoSala"></param>
        public Salas(int salaId, string nomeSala, string descricaoSala)
        {
            this.SalasId = salaId;
            this.NomeSala = nomeSala;
            this.DescricaoSala = descricaoSala;
        }
    }
}