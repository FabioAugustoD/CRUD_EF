using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD.Domain;

namespace CRUD.Repository
{
    public class AppDbContext : DbContext
    {
       public DbSet<Locacao> Locacoes { get; set; }
       public DbSet<Cliente> Clientes { get; set; }
       public DbSet<Filme> Filmes { get; set; }

       protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }

        public AppDbContext()
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
        }
    }


}

