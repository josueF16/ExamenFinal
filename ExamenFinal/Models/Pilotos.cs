using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Pilotos
    {
        [Key]
        public int Numero_Licencia { get; set; }
        public string Restricciones { get; set; }
        public float Salario { get; set; }
        public string Turno { get; set; }


    }
}