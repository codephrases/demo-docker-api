using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebApi.Controllers {

    [Route("[controller]")]
    [ApiController]
    public class HealthController : ControllerBase {

        private readonly ILogger<HealthController> logger;

        public HealthController(ILogger<HealthController> logger) {
            this.logger = logger;
        }

        [HttpGet]
        public IActionResult Health() {
            return Ok("healthy");
        }
    }
}
