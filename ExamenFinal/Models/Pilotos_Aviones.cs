using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Pilotos_Aviones
    {
        [Key]
        public int Pilotos_Numero_Licencia { get; set; }
        public int Aviones_IdAviones { get; set; }

    }
}