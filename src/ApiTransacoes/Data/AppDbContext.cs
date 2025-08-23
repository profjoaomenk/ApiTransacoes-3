using Microsoft.EntityFrameworkCore;
using MyApi.Models;

namespace MyApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Transacao> Transacoes { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Transacao>()
        //        .Property(t => t.DataTransacao)
        //        .HasDefaultValueSql("CURRENT_TIMESTAMP");
        //}

        // Para SQL Server
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transacao>()
                .Property(t => t.DataTransacao)
                .HasDefaultValueSql("SWITCHOFFSET(SYSDATETIMEOFFSET(), '-03:00')");
        }

    }
}
