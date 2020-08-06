using System;
using System.Collections.Generic;
using Infraestructure.Interface;
using System.Threading.Tasks;
using Infraestructure.Entity;
using Infraestructure.Querybuilder;
using System.Data;
using System.Data.Common;

namespace Infraestructure.Repository
{
    public class DiscoRepository : IDiscoRespository
    {        
        protected readonly DbConnection context;
        protected readonly DiscoKey discokey;
        protected readonly Builder builder;

        public DiscoRepository(DbConnection context, DiscoKey discokey, Builder builder)
        {
            this.context = context;
            this.discokey = discokey;
            this.builder = builder;
        }
        public async Task<ICollection<DiscoEntity>> GetDisco(int maxresults,
                                                             int offset)
        {
            List<DiscoEntity> disc = new List<DiscoEntity>();
            string query = string.Format(builder.GetQuery(discokey.getdisco), maxresults, offset);
            await context.OpenAsync();
            var command = context.CreateCommand();
            command.CommandText = query;
            var reader = await command.ExecuteReaderAsync();
            while (reader.Read())
            {
                disc.Add(new DiscoEntity{
                    Id = Convert.ToInt64(reader["id"].ToString()),
                    Name = reader["name"].ToString(),
                    Location = reader["location"].ToString(),
                    Street = reader["Street"].ToString(),
                    City = reader["City"].ToString()
                });
            }
            context.Close();
            return disc;
        }
    }
}
