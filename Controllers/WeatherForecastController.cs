using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using ProAgil.Api.Model;

namespace ProAgil.Api.Controllers
{
    [ApiController]
    [Route("eventos")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
      
        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return new Evento[] {
                new Evento() {
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    EventId = 1,
                    Local  = "Teste",
                    Lote= "Teste 3",
                    Quantidade = 1,
                    Tema = "Teste"
                },
            };
        }
    }
}
