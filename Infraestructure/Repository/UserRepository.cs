using System;
using System.Collections.Generic;
using Infraestructure.Interface;
using System.Threading.Tasks;
using Infraestructure.Entity;
using Infraestructure.Querybuilder;
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
        public async Task SignUp(UserEntity request){
            string query = string.Format(builder.GetQuery(userkey.signup), request.Name, request.Surname, request.Hashid, request.Birthday, request.Password, request.Birthday, request.Phonenumber, request.Extension, request.Genre);
            try{
                await context.OpenAsync();
                var command = context.CreateCommand();
                command.CommandText = query;
                await command.ExecuteNonQueryAsync();
            }catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
        public async Task<string> Login(int number, string password)
        {
            string response = string.Empty;
            string query = string.Format(builder.GetQuery(userkey.login), number, password);
            try{
                await context.OpenAsync();
                var command = context.CreateCommand();
                command.CommandText = query;
                var reader = await command.ExecuteReaderAsync();
                int i =0;
                while(reader.Read()){
                    response = reader["hashid"].ToString();
                    i++;
                }
                if(i>1){
                    throw new Exception("Inconsistency Db");
                }
            }catch(Exception e){
                Console.WriteLine(e.Message);
            }
            return response;
        }
        public async Task<UserEntity> GetUser(string hashid){
            string query = string.Format(builder.GetQuery(userkey.getuser), hashid);
            UserEntity user = new UserEntity();
            try{
                await context.OpenAsync();
                var command = context.CreateCommand();
                command.CommandText = query;
                var reader = await command.ExecuteReaderAsync();
                while (reader.Read())
                {
                    user.Id = Convert.ToInt64(reader["id"].ToString());
                    user.Name = reader["name"].ToString();
                    user.Surname = reader["surname"].ToString();
                    user.Hashid = hashid;
                    user.Phonenumber = Convert.ToInt32(reader["mobilephone"]);
                    user.Description = reader["description"].ToString();
                    user.Disco = reader["disco"].ToString();
                    user.Birthday = reader["birthday"].ToString();
                    user.Age = Convert.ToInt32(reader["age"]);
                    user.Genre = reader["genre"].ToString();
                    user.Interested = Convert.ToInt32(reader["interested"]);
                    user.Extension = Convert.ToInt32(reader["extension"]);
                }
                query = string.Format(builder.GetQuery(userkey.getlang), user.Id);
                command.CommandText = query;
                var langreader = await command.ExecuteReaderAsync();
                List<string> lang = new List<string>();
                while (langreader .Read()){
                    lang.Add(langreader["lang"].ToString());
                }
                user.Language = lang;
            }catch(Exception e){
                Console.WriteLine(e.Message);
            }
            return user;
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
        public async Task<UserEntity> GetProfile(string hashid){
            string query = string.Format(builder.GetQuery(userkey.getuser), hashid);
            UserEntity user = new UserEntity();
            try{
                await context.OpenAsync();
                var command = context.CreateCommand();
                command.CommandText = query;
                var reader = await command.ExecuteReaderAsync();
                while (reader.Read())
                {
                    user.Id = Convert.ToInt64(reader["id"].ToString());
                    user.Name = reader["name"].ToString();
                    user.Surname = reader["surname"].ToString();
                    user.Hashid = hashid;
                    user.Description = reader["description"].ToString();
                    user.Age = Convert.ToInt32(reader["age"]);
                }
                query = string.Format(builder.GetQuery(userkey.getlang), user.Id);
                command.CommandText = query;
                var langreader = await command.ExecuteReaderAsync();
                List<string> lang = new List<string>();
                while (langreader .Read()){
                    lang.Add(langreader["lang"].ToString());
                }
                user.Language = lang;
        }catch(Exception e){
            Console.WriteLine(e.Message);
        }
        return user;
    }
}
