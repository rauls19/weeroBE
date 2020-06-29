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
    [Route("api/[controller]")]
    public class Matchcontroller : ControllerBase
    {
        private readonly IMatchBI matcher;

        public Matchcontroller(IMatchBI matcher)
        {
            this.matcher = matcher;
        }
        [HttpPost]
        public async Task<IActionResult> GetListSwap(int userid, int interested, char genre, int discoid, int offset){
            ObjectResult response;
            try{
                var matches = await matcher.GetListSwap(userid, interested, genre, discoid, offset);
                response = new ObjectResult(matches);
                response.StatusCode = (int)CodesResponse.Ok;
            }catch(Exception e){
                response = new ObjectResult(e.Message);
                response.StatusCode = (int)CodesResponse.InternalError;
            }
            return response;
        }
    }
}
