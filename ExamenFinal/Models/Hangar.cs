using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace WebApplication2.Models
{
    public class Hangar
    {
        [Key]
        public int Numero_Hangar { get; set; }
        public int Capacidad { get; set; }
        public string  Localizacion { get; set; }
    }
}