using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Core.Interface;
using Core.Model;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/")]
    public class Healthcontroller : ControllerBase
    {
        [HttpGet]
        [Route("HealthCheck")]
        public async Task<bool> HealthCheck(){
            return true;
        }
    }
}