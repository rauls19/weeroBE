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
            //TODO check Likes, check matches and after get users
            List<MatchEntity> matchlist = new List<MatchEntity>();
            string query = string.Empty;
            //Males straight
            if(genre == 'M' && interested == 1)
                query = string.Format(matchkey.homostraight, userid, 'F', 0, discoid, userid, userid, userid, offset);
            //Females straight
            if(genre == 'F' && interested == 0)
                query = string.Format(matchkey.homostraight, userid, 'M', 1, discoid, userid, userid, userid, offset);
            //Homosexuals
            if((genre == 'M' && interested == 0) || (genre == 'F' && interested == 1))
                query = string.Format(matchkey.homostraight , userid, genre, interested, discoid, userid, userid, userid, offset);
            //TODO bisexuals
            await context.OpenAsync();
            var command = context.CreateCommand();
            command.CommandText = query;
            var reader = await command.ExecuteReaderAsync();
            while (reader.Read())
            {
                matchlist.Add(new MatchEntity{
                    Name = reader["name"].ToString(),
                    Surname = reader["surname"].ToString(),
                    //Age = int.Parse(reader["age"].ToString()),
                    Description = reader["description"].ToString()
                });
            }
            context.Close();
            return matchlist;
        }
        public async Task<bool> MatchEvaluation(int userorigin, int userlike){
            string query=String.Empty;
            return false;
        }
        public async Task UnMatch(int userorigin, int userlike){
            string query=String.Empty;
            query = String.Format(builder.GetQuery(matchkey.insertdislike), userorigin, userlike);
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
