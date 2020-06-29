using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Infraestructure.Entity;

namespace Infraestructure.Interface
{
    public interface IMatchRepository
    {
        Task<ICollection<MatchEntity>> GetSwap(int userid, int interested, char genre, int discoid, int offset);
    }
}
