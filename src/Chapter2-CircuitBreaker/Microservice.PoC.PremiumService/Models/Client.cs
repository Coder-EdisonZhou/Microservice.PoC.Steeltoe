using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.PoC.PremiumService.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public int ClientAge { get; set; }
        public string Remarks { get; set; }
    }
}
