using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SaitHH.Controllers
{


    [Route("Jobs")]
    public class HHController : Controller
    {
        static readonly List<Service> data;
        static HHController()
        {
            using (lab3Context db = new lab3Context())
            {
                data = db.Service.ToList();
            }
        }
        [HttpGet("")]
        public IEnumerable<Service> Get()
        {
            return data;
        }

    }
}
