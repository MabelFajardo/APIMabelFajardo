using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio1.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class CalcularSueldo : ControllerBase
    {
        [HttpPost]
        public IActionResult Calculadora([Required] string nombre, [Required] long horasDeTrabajo, [Required] decimal valorPagoHora)
        {
            if (string.IsNullOrEmpty (nombre) || horasDeTrabajo <= 0 || valorPagoHora <= 0)
            {
                return BadRequest("Por favor ingresa valores válidos para el nombre, horas de trabajo y valor del pago por hora.");
            }

            decimal sueldo = horasDeTrabajo * valorPagoHora;

            return Ok($"El sueldo de {nombre} es: {sueldo}");
        }
    }
}
