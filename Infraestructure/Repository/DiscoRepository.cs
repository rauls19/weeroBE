using System;
using System.Collections.Generic;
using Infraestructure.Interface;
using System.Threading.Tasks;
using Infraestructure.Entity;
using System.Data;

namespace Infraestructure.Repository
{
    public class DiscoRepository : IDiscoRespository
    {
        private readonly IDbConnection context;
        public DiscoRepository(IDbConnection context)
        {
            this.context = context;
        }
        public async Task<ICollection<DiscoEntity>> GetDisco(int maxresults, int offset)
        {
            //TODO try catch
            List<DiscoEntity> disc = new List<DiscoEntity>();
            string query = @"SELECT id, ""name"", ""location"", logo, Street, City FROM discos limit "+maxresults+ " offset "+offset;
            context.Open();
            var command = context.CreateCommand();
            command.CommandText = query;
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                disc.Add(new DiscoEntity{
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
