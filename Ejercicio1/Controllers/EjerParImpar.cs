using Microsoft.AspNetCore.Mvc;

namespace Ejercicio1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EjerParImpar : ControllerBase
    {
        [HttpGet("{numer}")]
        public IActionResult ProcesarNumero([FromRoute] long numer)
        {
            string result = (numer % 2 == 0) ? "par" : "impar";

            return Ok($"El número {numer} es {result}.");
        }
    }
}
