using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Infraestructure.Entity;

namespace Infraestructure.Interface
{
    public interface IUserRepository
    {
        Task SignUp(UserEntity request);
        Task<string> Login(int number, string password);
        Task UpdatePartyToGo(int id, string hashid);
        Task UpdatePhoto(string id, int order);
        Task<UserEntity> GetUser(string hashid);
    }
}
