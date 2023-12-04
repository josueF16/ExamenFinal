using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Aviones
    {
        [Key]
        public int IdAviones { get; set; }
        public string Modelo { get; set; }
        public float Peso { get; set; }
        public int Capacidad { get; set; }
        public int IdHangar { get; set; }

    }
}