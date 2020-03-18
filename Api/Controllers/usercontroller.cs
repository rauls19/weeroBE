using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Core.Interface;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class usercontroller : ControllerBase
    {
        private readonly IUser _user;

        public usercontroller(IUser user)
        {
            _user = user;
        }
        [HttpGet]
        public async Task<string> Get()
        {
            return await _user.Test();
        }
        
    }
}
