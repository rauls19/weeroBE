using System.Collections.Generic;
using Infraestructure.Interface;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Infraestructure.Entity;
using System.Data;

namespace Infraestructure.Repository
{
    public class UserRepository : IUserRepository
    {
        protected readonly IDbConnection context;
        public UserRepository(IDbConnection context)
        {
            this.context = context;
        }
        public async Task<ICollection<UserEntity>> Login(int number, string password)
        {
            var user = context.Set<UserEntity>().FromSqlRaw("").ToListAsync();
            return await user;
        }
        public async Task UpdatePartyToGo(int id, string hashid){
            Task.Run(() => {
                string query = @"UPDATE users SET disco="+id+" where hashid ="+hashid+";";
                context.Open();
                var command = context.CreateCommand();
                command.CommandText = query;
                command.ExecuteNonQuery();
                context.Close();
            });
        }
    }
}
