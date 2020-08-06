using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

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