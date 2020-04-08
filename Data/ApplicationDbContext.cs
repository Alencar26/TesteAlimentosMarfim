using System;
using System.Collections.Generic;
using System.Text;
using AlimentosMarfim.Models.Entidades;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AlimentosMarfim.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<Setor> Setores { get; set; }
        public DbSet<Turno> Turnos { get; set; }
        public DbSet<Cargo> Cargos { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
