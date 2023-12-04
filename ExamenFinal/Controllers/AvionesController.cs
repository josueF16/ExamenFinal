using Microsoft.AspNetCore.Mvc;
using VideoJuego.Context;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AvionesController : ControllerBase
    {
        private readonly ILogger<AvionesController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public AvionesController(
            ILogger<AvionesController> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear Aviones
        //[Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Aviones aviones)
        {
            _aplicacionContexto.Aviones.Add(aviones);
            _aplicacionContexto.SaveChanges();
            return Ok(aviones);
        }
        //READ: Obtener lista de Aviones
        //[Route("")]
        [HttpGet]

        public IEnumerable<Aviones> Get()
        {
            return _aplicacionContexto.Aviones.ToList();
        }

        //Update: Modificar Aviones
        //[Route("/id")]
        [HttpPut]
        public IActionResult Put([FromBody] Aviones aviones)
        {
            _aplicacionContexto.Aviones.Update(aviones);
            _aplicacionContexto.SaveChanges();
            return Ok(aviones);

        }
        //Delete: Eliminar Aviones
        //[Route("/id")]
        [HttpDelete]
        public IActionResult Delete(int avionesID)
        {
            _aplicacionContexto.Aviones.Remove(
                _aplicacionContexto.Aviones.ToList()
                .Where(x=>x.IdAviones == avionesID)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(avionesID);
        }
    }
}