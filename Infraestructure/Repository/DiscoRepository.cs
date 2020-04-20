using System;
using System.Collections.Generic;
using Infraestructure.Interface;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Infraestructure.Entity;
using System.Data;
using Microsoft.Data.SqlClient;

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
            using (SqlConnection con = new SqlConnection("Server=localhost;Database=postgres;Uid=postgres;Password=raul;"))
            {
                con.Open();
                string query = @"SELECT id, ""name"", ""location"", logo FROM discos limit "+maxresults+ " offset "+offset;
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader["Title"]);
                }
            }
            /*string query = @"SELECT id, ""name"", ""location"", logo FROM discos limit "+maxresults+ " offset "+offset;
            context.Open();
            var f = context.CreateCommand();
            f.CommandText = query;
            var reader = f.ExecuteReader();
            while (reader.Read())
            {
                System.Diagnostics.Debug.WriteLine(String.Format("{0}", reader[0]));
            }*/
            //Console.WriteLine("Discos rep: "+discos.FirstOrDefaultAsyn());
            return null;
        }
    }
}
