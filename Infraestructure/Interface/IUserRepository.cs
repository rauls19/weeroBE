using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Infraestructure.Entity;

namespace Infraestructure.Interface
{
    public interface IUserRepository
    {
        Task<ICollection<UserEntity>> Login(int number, string password);
        Task UpdatePartyToGo(int id, string hashid);
    }
}
