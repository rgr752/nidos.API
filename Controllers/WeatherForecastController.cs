using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace nidos.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly DataContext _context;
        
        private readonly ILogger<WeatherForecastController> _logger;
        public WeatherForecastController(DataContext context, ILogger<WeatherForecastController> logger)
        {
            this._context = context;  
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetValues()
        {
            var values = _context.Values.ToList();
            return Ok(values);
        }
        
        [HttpGet("{id}")]
        public IActionResult GetValue(int id)
        {
            var value = _context.Values.FirstOrDefault(x => x.Id == id);
            return Ok(value);
        }
    }
}
