using System.Collections.Immutable;
using System.Collections.Generic;
using Infraestructure.Interface;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Infraestructure.Entity;
using Infraestructure.Querybuilder;
using System.Data;
using System.Data.Common;

namespace Infraestructure.Repository
{
    public class UserRepository : IUserRepository
    {
        protected readonly DbConnection context;
        protected readonly UserKey userkey;
        protected readonly Builder builder;
        public UserRepository(DbConnection context, UserKey userkey, Builder builder)
        {
            this.context = context;
            this.userkey = userkey;
            this.builder = builder;
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
            string query = string.Format(builder.GetQuery(userkey.updatephoto), id, order);
            await context.OpenAsync();
            var command = context.CreateCommand();
            command.CommandText = query;
            var count = await command.ExecuteScalarAsync();
            if((int)count == 0){
                query = string.Format(builder.GetQuery(userkey.insertupdatephoto), id, order);
                command.CommandText = query;
                await command.ExecuteNonQueryAsync();
            }
            context.Close();
        }
    }
}
