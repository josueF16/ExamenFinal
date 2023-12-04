using Microsoft.AspNetCore.Mvc;
using VideoJuego.Context;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Pilotos_AvionesController : ControllerBase
    {
        private readonly ILogger<Pilotos_AvionesController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public Pilotos_AvionesController(
            ILogger<Pilotos_AvionesController> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear estudiantes
        //[Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Pilotos_Aviones pilotos_Aviones)
        {
            _aplicacionContexto.Pilotos_Aviones.Add(pilotos_Aviones);
            _aplicacionContexto.SaveChanges();
            return Ok(pilotos_Aviones);
        }
        //READ: Obtener lista de estudiantes
        //[Route("")]
        [HttpGet]

        public IEnumerable<Pilotos_Aviones> Get()
        {
            return _aplicacionContexto.Pilotos_Aviones.ToList();
        }

        //Update: Modificar estudiantes
        //[Route("/id")]
        [HttpPut]
        public IActionResult Put([FromBody] Pilotos_Aviones pilotos_Aviones)
        {
            _aplicacionContexto.Pilotos_Aviones.Update(pilotos_Aviones);
            _aplicacionContexto.SaveChanges();
            return Ok(pilotos_Aviones);

        }
        //Delete: Eliminar estudiantes
        //[Route("/id")]
        [HttpDelete]
        public IActionResult Delete(int pilotos_avioneSID)
        {
            _aplicacionContexto.Pilotos_Aviones.Remove(
                _aplicacionContexto.Pilotos_Aviones.ToList()
                .Where(x=>x.Aviones_IdAviones == pilotos_avioneSID)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(pilotos_avioneSID);
        }
    }
}