using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using GestaoDeSalas.Models.Sala;

namespace GestaoDeSalas.Models.BancoDeDados
{
    public class BancoDBContext : DbContext
    {
        public BancoDBContext() : base("name=DefaultConnection")
        { }

        public virtual DbSet<Salas> Salas { get; set; }
        public virtual DbSet<SalasAgendadas> SalasAgendadas { get; set; }
        public virtual DbSet<Funcionarios.Funcionario> Funcionario { get; set; }
        public virtual DbSet<Funcionarios.LoginFuncionario> LoginFuncionario { get; set; }
    }
}