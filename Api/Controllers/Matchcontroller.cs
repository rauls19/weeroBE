using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Core.Interface;

namespace Api.Controllers
{
  [ApiController]
    [Route("api/")]
    public class Matchcontroller : ControllerBase
    {
        private readonly IMatchBI matcher;

        public Matchcontroller(IMatchBI matcher)
        {
            this.matcher = matcher;
        }
        [HttpPost]
        [Route("GetListSwap")]
        public async Task<IActionResult> GetListSwap(string userid, int interested, char genre, int discoid, int offset){
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
        [HttpPost]
        [Route("PlaySwapping")]
        public async Task<IActionResult> PlaySwapping(int userorigin, int userlike){
            ObjectResult response;
            try{
                bool matched = await matcher.MatchedUser(userorigin,userlike);
                response = new ObjectResult(matched);
                response.StatusCode = (int)CodesResponse.Ok;
            }catch(Exception e){
                response = new ObjectResult(e.Message);
                response.StatusCode = (int)CodesResponse.InternalError;
            }
            return response;
        }
        [HttpPost]
        [Route("PlayUnmatch")]
        public async Task PlayUnmatch(int userorigin, int userlike){
            try{
                //await matcher.UnMatchedUser(userorigin, userlike);
            }catch(Exception e){
                //Logger
            }
        }
    }
}
