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
    public class Usercontroller : ControllerBase
    {
        
        private readonly IUserBI user;

        public Usercontroller(IUserBI user)
        {
            this.user = user;
        }
        [HttpPost]
        [Route("UploadPhoto")]
        public async Task Uploadphoto(Image request){
            Guid obj = Guid.NewGuid();
            Console.WriteLine(obj.ToString().ToLower());
            //await user.UploadImage(request.hashid, request.order, request.image);
        }
        /*
        [HttpGet]
        public async Task<ResponseDto> GetUser(UserDto request)
        {
            ResponseDto response = new ResponseDto();
            response.Result = await user.Test();
            return response;
        }
        [HttpPost]
        public async Task<ResponseDto> LoginUser(UserDto request){
            ResponseDto response = new ResponseDto();
            //#TODO Error
            if(request.Phonenumber == 0 || string.IsNullOrEmpty(request.Password)){
                response.Code = (int)CodesResponse.Unauthorized;
            }
            try{

                response.Code = (int)CodesResponse.Ok;
            }catch(Exception e){

                response.Code = (int)CodesResponse.InternalError;
            }
            return response;
        }/*
        [HttpPost]
        public async Task<ResponseDto> UpdateDisco(long requestId, string requestuser){
            ObjectResult response;
            if(request.Phonenumber == 0 || string.IsNullOrEmpty(request.Password)){
                response.Code = (int)CodesResponse.Unauthorized;
                return response;
            }
            try{
                await user.UpdatePartyToGo(requestId, requestuser);
                response.Code = (int)CodesResponse.Ok;
            }catch(Exception e){

            }
            return response;
        }
        /*
        [HttpPost]
        public async Task<ResponseDto> SignUp(UserDto request){
            ResponseDto response = new ResponseDto();
        }
        [HttpPost]
        public async Task<ResponseDto> UpdatePhoto(UserDto request){
            ResponseDto response = new ResponseDto();
        }
        [HttpPost]
        public async Task<ResponseDto> UpdateProfile(UserDto request){
            ResponseDto response = new ResponseDto();
        }*/
    }
}