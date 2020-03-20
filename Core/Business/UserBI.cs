using System;
using Core.Interface;
using System.Threading.Tasks;
using Core.Model;
using Infraestructure.Interface;
using System.Linq;
using Core.Mapper;

namespace Core.Business
{
    public class UserBI:IUserBI
    {
        private readonly IUserRepository repository;

        public UserBI(IUserRepository repository)
        {
            this.repository = repository;
        }
        public async Task<string> Test(){
            return "Hola";
        }
        public async Task<UserDto> LoginUser(int phone, string pass){
            
            var user = await repository.Login(phone, pass);
            
            if(user.Count >1) Console.WriteLine("Inconsistency DB");

            return user.ToList().SingleOrDefault().EntityDto();
        }
    }
}
