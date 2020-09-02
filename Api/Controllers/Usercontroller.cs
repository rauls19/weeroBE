using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Core.Interface;
using Core.Model;

namespace Api.Controllers
{
  [ApiController]
    [Route("api/")]
    public class Usercontroller : ControllerBase
    {
        
        private readonly IUserBI user;

        public Usercontroller(IUserBI user)
        {
            this.user = user;
        }
        [HttpPost]
        [Route("SignUp")]
        public async Task<IActionResult> SignUp(UserDto request){
            ObjectResult response;
            try{
                response = new ObjectResult(await user.SignUp(request));
                response.StatusCode = (int)CodesResponse.Ok;
            }catch(Exception e){
                response = new ObjectResult(e.Message);
                response.StatusCode = (int)CodesResponse.InternalError;
            }
            return response;
        }
        [HttpPost]
        [Route("GetUser")]
        public async Task<IActionResult> GetUser(string request)
        {
            ObjectResult response;
            try{
                var profile = await user.GetUser(request);
                response = new ObjectResult(profile);
                response.StatusCode = (int)CodesResponse.Ok;
            }catch(Exception e){
                response = new ObjectResult(e.Message);
                response.StatusCode = (int)CodesResponse.InternalError;
            }
            return response;
        }
        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> LogIn(UserDto request){
            ObjectResult response;
            try{
                var profile = await user.LoginUser(request);
                response = new ObjectResult(profile);
                response.StatusCode = (int)CodesResponse.Ok;
            }catch(Exception e){
                response = new ObjectResult(e.Message);
                response.StatusCode = (int)CodesResponse.InternalError;
            }
            return response;
        }
        [HttpPost]
        [Route("UploadPhoto")]
        public async Task Uploadphoto(Image request){
            await user.UploadImage(request.hashid, request.order, request.image);
        }
        [HttpPost]
        [Route("VisitProfile")]
        public async Task<IActionResult> VisitProfile(string request){
            ObjectResult response;
            try{
                var profile = await user.GetProfile(request);
                response = new ObjectResult(profile);
                response.StatusCode = (int)CodesResponse.Ok;
            }catch(Exception e){
                response = new ObjectResult(e.Message);
                response.StatusCode = (int)CodesResponse.InternalError;
            }
            return response;
        }
        [HttpPost]
        [Route("UpdateProfile")]
        public async Task UpdateProfile(UserDto request){
            try{
                await user.UpdateFieldsProfile(request);
            }catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
        [HttpPost]
        [Route("UpdateConfiguration")]
        public async Task UpdateConfig(UserDto request){
            try{
                await user.UpdatePersonalInformation(request);
            }catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
        [HttpPost]
        [Route("UpdatePrivatConfiguration")]
        public async Task UpdatePrivatConfig(string request, string idem){
            try{
                await user.UpdatePrivateInformation(request, idem);
            }catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
    }
}