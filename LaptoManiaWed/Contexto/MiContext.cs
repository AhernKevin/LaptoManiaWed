using LaptoManiaWed.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace LaptoManiaWed.Contexto
{
    public class MiContext : DbContext

    {
        public MiContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }


        //public DbSet<Ingeniero> Ingenieroes { get; set; }
        //public DbSet<Pago> Pagos { get; set; }

    }
}
