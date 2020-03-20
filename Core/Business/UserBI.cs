using System;
using Core.Interface;
using System.Threading.Tasks;
using Core.Model;

namespace Core.Business
{
    public class UserBI:IUserBI
    {
        //public UserBI()
        public async Task<string> Test(){
            return "Hola";
        }
        public async Task<UserDto> LoginUser(string phone, string pass){
            
            
            return null;
        }
    }
}
