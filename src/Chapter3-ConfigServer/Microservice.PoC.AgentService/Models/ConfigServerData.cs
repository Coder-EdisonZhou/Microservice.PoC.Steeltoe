using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.PoC.AgentService.Models
{
    public class ConfigServerData
    {
        public Info Info { get; set; }
    }

    public class Info
    {
        public string Profile { get; set; }
        public string Remarks { get; set; }
    }
}
