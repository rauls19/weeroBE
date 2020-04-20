using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Infraestructure.Entity;

namespace Infraestructure.Interface
{
    public interface IDiscoRespository
    {
        Task<ICollection<DiscoEntity>> GetDisco(int maxresults, int offset);
    }
}
