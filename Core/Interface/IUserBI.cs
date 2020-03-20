using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Model;

namespace Core.Interface
{
    public interface IUserBI
    {
        Task<string> Test();
        Task<UserDto> LoginUser(string phone, string pass);
    }
}