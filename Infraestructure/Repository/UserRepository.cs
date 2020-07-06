using System.Collections.Generic;
using Infraestructure.Interface;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Infraestructure.Entity;
using System.Data;
using System.Data.Common;

namespace Infraestructure.Repository
{
    public class UserRepository : IUserRepository
    {
        protected readonly DbConnection context;
        public UserRepository(DbConnection context)
        {
            this.context = context;
        }
        public async Task<ICollection<UserEntity>> Login(int number, string password)
        {
            //var user = context.Set<UserEntity>().FromSqlRaw("").ToListAsync();
            //return await user;
            return null;
        }
        public async Task UpdatePartyToGo(int id, string hashid){
            /* Task.Run(() => {
                string query = @"UPDATE users SET disco="+id+" where hashid ="+hashid+";";
                context.Open();
                var command = context.CreateCommand();
                command.CommandText = query;
                command.ExecuteNonQuery();
                context.Close(); 
            });*/
        }
        public async Task UpdatePhoto(string id, int order){
            string query = @"SELECT COUNT(*) FROM pictures WHERE hashid="+id+" orderpic="+order;
            await context.OpenAsync();
            var command = context.CreateCommand();
            command.CommandText = query;
            var count = await command.ExecuteScalarAsync();
            if(true){
                query = @"INSERT INTO pictures (hashid, orderpic) VALUES ("+id+","+order+");";
                command.CommandText = query;
                await command.ExecuteNonQueryAsync();
            }
        }
    }
}
