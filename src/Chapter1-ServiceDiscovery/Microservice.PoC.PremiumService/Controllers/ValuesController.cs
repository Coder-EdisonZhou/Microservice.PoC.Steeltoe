using Microservice.PoC.PremiumService.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microservice.PoC.PremiumService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IClientService _clientService;
        private ILogger<ValuesController> _logger;

        public ValuesController(IClientService clientService, ILogger<ValuesController> logger)
        {
            _clientService = clientService;
            _logger = logger;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { $"Request Time: {DateTime.Now.ToString()}", "PremiumService-value1", "PremiumService-value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<string> Get(int id)
        {
            _logger?.LogInformation($"api/values/{id}");
            return await _clientService.GetClientName(id);
        }
    }
}
