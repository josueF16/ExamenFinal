using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace VideoJuego.Context
{
    public class AplicacionContexto : DbContext
    {
        public AplicacionContexto
            (DbContextOptions<AplicacionContexto> options)
            : base(options) { }


        public DbSet<Aviones> Aviones { get; set; }
        public DbSet<Hangar> Hangar { get; set; }
        public DbSet<Pilotos> Pilotos { get; set; }
        public DbSet<Pilotos_Aviones> Pilotos_Aviones { get; set; }


    }
}
