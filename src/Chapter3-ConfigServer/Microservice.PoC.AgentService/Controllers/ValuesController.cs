using Microservice.PoC.AgentService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System.Collections.Generic;

namespace Microservice.PoC.AgentService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IOptionsSnapshot<ConfigServerData> IConfigServerData { get; set; }

        private IConfigurationRoot Config { get; set; }

        public ValuesController(IConfigurationRoot config, IOptionsSnapshot<ConfigServerData> configServerData)
        {
            if (configServerData != null)
            {
                IConfigServerData = configServerData;
            }

            Config = config;
        }

        [HttpGet]
        [Route("/refresh")]
        public IActionResult Refresh()
        {
            if (Config != null)
            {
                Config.Reload();
            }

            return Ok("Refresh Config Successfully!");
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var config = IConfigServerData.Value;
            return new string[] { $"Profile : {config.Info.Profile}",
                $"Remarks : {config.Info.Remarks}" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }
    }
}
