using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DataAccessLayer;
using Microsoft.Extensions.Configuration;
using System.Data.Common;

namespace ShoppingApp_Backend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IConfiguration configuration;
        public ValuesController(IConfiguration iConfig)
        {
            configuration = iConfig;
        }
        public IEnumerable<string> Get()
        {

            yield return "hello";
        }
    }
}
