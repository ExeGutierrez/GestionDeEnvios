using GestionDeEnvios.DB.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeEnvios.DB.Data
{
    public class Context : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        public DbSet<Presupuesto> presupuestos { get; set; }
        public DbSet<Rendimiento> rendimientos { get; set; }
        public DbSet<ServRep> servReps { get; set; }
        public DbSet<Socio> socios { get; set; }
        public Context(DbContextOptions options) : base(options)
        {
           

    }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var cascadeFks = modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership
                            && fk.DeleteBehavior == DeleteBehavior.Cascade);
            foreach (var fk in cascadeFks)
            {
                fk.DeleteBehavior = DeleteBehavior.Restrict;
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}
