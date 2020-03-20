using System.Collections.Generic;
using Infraestructure.Interface;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Infraestructure.Entity;

namespace Infraestructure.Repository
{
    public class UserRepository : IUserRepository
    {
        protected readonly DbContextBase context;
        public UserRepository(DbContextBase context)
        {
            this.context = context;
        }
        public async Task<ICollection<UserEntity>> Login(int number, string password)
        {
            var user = context.Set<UserEntity>().FromSqlRaw("").ToListAsync();
            return await user;
        }
    }
}
