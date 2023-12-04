using Microsoft.AspNetCore.Mvc;
using VideoJuego.Context;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PilotosController : ControllerBase
    {
        private readonly ILogger<PilotosController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public PilotosController(
            ILogger<PilotosController> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear estudiantes
        //[Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Pilotos pilotos)
        {
            _aplicacionContexto.Pilotos.Add(pilotos);
            _aplicacionContexto.SaveChanges();
            return Ok(pilotos);
        }
        //READ: Obtener lista de estudiantes
        //[Route("")]
        [HttpGet]

        public IEnumerable<Pilotos> Get()
        {
            return _aplicacionContexto.Pilotos.ToList();
        }

        //Update: Modificar estudiantes
        //[Route("/id")]
        [HttpPut]
        public IActionResult Put([FromBody] Pilotos pilotos)
        {
            _aplicacionContexto.Pilotos.Update(pilotos);
            _aplicacionContexto.SaveChanges();
            return Ok(pilotos);

        }
        //Delete: Eliminar estudiantes
        //[Route("/id")]
        [HttpDelete]
        public IActionResult Delete(int pilotosID)
        {
            _aplicacionContexto.Pilotos.Remove(
                _aplicacionContexto.Pilotos.ToList()
                .Where(x=>x.Numero_Licencia == pilotosID)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(pilotosID);
        }
    }
}