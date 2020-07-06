using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Model;

namespace Core.Interface
{
    public interface IUserBI
    {
        Task<string> Test();
        Task<UserDto> LoginUser(int phone, string pass);
        Task UpdatePartyToGo(int id, string hashid);
        Task UploadImage(string containerName, int order, string image);
    }
}