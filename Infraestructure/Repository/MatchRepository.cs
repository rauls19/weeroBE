using System.Data.Common;
using System;
using System.Collections.Generic;
using Infraestructure.Interface;
using System.Threading.Tasks;
using Infraestructure.Entity;
using Infraestructure.Querybuilder;


namespace Infraestructure.Repository
{
    public class MatchRepository : IMatchRepository
    {
        protected readonly DbConnection context;
        protected readonly MatchKey matchkey;
        protected readonly Builder builder;

        public MatchRepository(DbConnection context, MatchKey matchkey, Builder builder)
        {
            this.context = context;
            this.matchkey = matchkey;
            this.builder = builder;
        }
        public async Task<ICollection<MatchEntity>> GetSwap(string userid, int interested, char genre, int discoid,
                                                            int offset)
        {
            //TODO try catch
            List<MatchEntity> matchlist = new List<MatchEntity>();
            string query = string.Empty;
            //Males straight
            if(genre == 'M' && (interested == 1 || interested == 2))
                query = string.Format(matchkey.getswaplist, userid, 'F', 0, discoid, userid, userid, userid, offset);
            //Females straight
            if(genre == 'F' && (interested == 0 || interested == 2))
                query = string.Format(matchkey.getswaplist, userid, 'M', 1, discoid, userid, userid, userid, offset);
            //Homosexuals
            if((genre == 'M' && interested == 0) || (genre == 'F' && interested == 1))
                query = string.Format(matchkey.getswaplist , userid, genre, interested, discoid, userid, userid, userid, offset);
            //Bisexuals
            if(interested == 2)
                query = "( "+query+" ) union ( "+string.Format(matchkey.getswaplist , userid, genre, interested, discoid, userid, userid, userid, offset)+" )";
            await context.OpenAsync();
            var command = context.CreateCommand();
            command.CommandText = query;
            var reader = await command.ExecuteReaderAsync();
            while (reader.Read())
            {
                matchlist.Add(new MatchEntity{
                    Name = reader["name"].ToString(),
                    Surname = reader["surname"].ToString(),
                    Age = Convert.ToInt32(reader["age"]),
                    Description = reader["description"].ToString(),
                    Identifier = reader["hashid"].ToString()
                });
            }
            context.Close();
            return matchlist;
        }
        public async Task<bool> MatchEvaluation(string userorigin, string userlike){
            string query=string.Format(builder.GetQuery(matchkey.islike), userlike, userorigin);
            bool matched = false;
            try{
                await context.OpenAsync();
                var command = context.CreateCommand();
                command.CommandText = query;
                var count = await command.ExecuteScalarAsync();
                if((int)count == 1){
                    query=string.Format(builder.GetQuery(matchkey.matched), userlike, userorigin);
                    command = context.CreateCommand();
                    command.CommandText = query;
                    await command.ExecuteNonQueryAsync();
                   matched = true;
                }else{
                    query=string.Format(builder.GetQuery(matchkey.insertlike), userorigin, userlike);
                    command = context.CreateCommand();
                    command.CommandText = query;
                    await command.ExecuteNonQueryAsync();
                }
            }catch(Exception e){
                Console.WriteLine(e.Message);
            }
            context.Close();
            return matched;
        }
        public async Task UnMatch(string userorigin, string userlike){
            string query=String.Format(builder.GetQuery(matchkey.insertdislike), userorigin, userlike);
            try{
                await context.OpenAsync();
                var command = context.CreateCommand();
                command.CommandText = query;
                await command.ExecuteNonQueryAsync();
            }catch(Exception e){
                Console.WriteLine(e.Message);
            }
            context.Close();
        }
    }
}
