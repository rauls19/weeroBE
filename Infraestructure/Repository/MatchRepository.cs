using System;
using System.Collections.Generic;
using Infraestructure.Interface;
using System.Threading.Tasks;
using Infraestructure.Entity;
using System.Data;

namespace Infraestructure.Repository
{
    public class MatchRepository : IMatchRepository
    {
        private readonly IDbConnection context;
        public MatchRepository(IDbConnection context)
        {
            this.context = context;
        }
        public async Task<ICollection<MatchEntity>> GetSwap(int userid, int interested, char genre, int discoid, int offset)
        {
            //TODO try catch
            //TODO check Likes, check matches and after get users
            List<MatchEntity> matchlist = new List<MatchEntity>();
            string query = "";
            //Males straight
            if(genre == 'M' && interested == 1)
                query = @"SELECT * FROM users WHERE id != "+ userid +" and genre = 'F' and interested = 0 and disco = "+discoid+ " limit 20 offset "+ offset;
            //Females straight
            if(genre == 'F' && interested == 0)
                query = @"SELECT * FROM users WHERE id != "+ userid +" and genre = 'M' and interested = 1 and disco = "+discoid+ " limit 20 offset "+ offset;
            //Homosexuals
            if((genre == 'M' && interested == 0) || (genre == 'F' && interested == 1))
                query = @"SELECT * FROM users WHERE id != "+ userid +" and genre = '"+genre+"' and interested = "+interested+" and disco = "+discoid+ " limit 20 offset "+ offset;
            //TODO bisexuals
            if(genre == 'M' && interested == 2)
                query = @"SELECT * FROM users WHERE id != "+ userid +" and  "+discoid+"limit 20 offset "+ offset;
            if(genre == 'F' && interested == 2)
                query = @"SELECT * FROM users WHERE id != "+ userid +" and  "+discoid+"limit 20 offset "+ offset;

            context.Open();
            var command = context.CreateCommand();
            command.CommandText = query;
            var reader = command.ExecuteReader();
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
    }
}
