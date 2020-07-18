using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Core.Interface;
using Core.Model;
using System.Diagnostics;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/")]
    public class Discocontroller : ControllerBase
    {
        private readonly IDiscoBI disco;

        public Discocontroller(IDiscoBI disco)
        {
            this.disco = disco;
        }
        [HttpPost]
        [Route("GetDiscos")]
        public async Task<IActionResult> GetListDisco(int maxresults, int offset){
            ObjectResult response;
            try{
                var discos = await disco.GetListDisco(maxresults, offset);
                response = new ObjectResult(discos);
                response.StatusCode = (int)CodesResponse.Ok;
            }catch(Exception e){
                response = new ObjectResult(e.Message);
                response.StatusCode = (int)CodesResponse.InternalError;
            }
            return response;
        }
    }
}