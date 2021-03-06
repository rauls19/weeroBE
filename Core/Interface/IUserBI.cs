using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Model;

namespace Core.Interface
{
    public interface IUserBI
    {
        Task<string> SignUp(UserDto request);
        Task<string> LoginUser(UserDto request);
        Task UpdatePartyToGo(int id, string hashid);
        Task UploadImage(string containerName, int order, string image);
        Task<UserDto> GetUser(string request);
        Task<UserProfile> GetProfile(string request);
        Task UpdateFieldsProfile(UserDto request);
        Task UpdatePersonalInformation(UserDto request);
        Task UpdatePrivateInformation(string request, string value);
    }
}