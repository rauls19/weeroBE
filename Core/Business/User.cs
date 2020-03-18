using System;
using Core.Interface;
using System.Threading.Tasks;

namespace Core.Business
{
    public class User:IUser
    {
        public async Task<string> Test(){
            return "Hola";
        }
    }
}
