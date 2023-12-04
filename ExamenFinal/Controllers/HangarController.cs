using Microsoft.AspNetCore.Mvc;
using VideoJuego.Context;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HangarController : ControllerBase
    {
        private readonly ILogger<HangarController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public HangarController(
            ILogger<HangarController> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear Hangar
        //[Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Hangar hangar)
        {
            _aplicacionContexto.Hangar.Add(hangar);
            _aplicacionContexto.SaveChanges();
            return Ok(hangar);
        }
        //READ: Obtener lista de Hangar
        //[Route("")]
        [HttpGet]

        public IEnumerable<Hangar> Get()
        {
            return _aplicacionContexto.Hangar.ToList();
        }

        //Update: Modificar Hangar
        //[Route("/id")]
        [HttpPut]
        public IActionResult Put([FromBody] Hangar hangar)
        {
            _aplicacionContexto.Hangar.Update(hangar);
            _aplicacionContexto.SaveChanges();
            return Ok(hangar);

        }
        //Delete: Eliminar Hangar
        //[Route("/id")]
        [HttpDelete]
        public IActionResult Delete(int hangarID)
        {
            _aplicacionContexto.Hangar.Remove(
                _aplicacionContexto.Hangar.ToList()
                .Where(x=>x.Numero_Hangar == hangarID)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(hangarID);
        }
    }
}