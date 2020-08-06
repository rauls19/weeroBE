using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Infraestructure.Entity;

namespace Infraestructure.Interface
{
    public interface IMatchRepository
    {
        Task<ICollection<MatchEntity>> GetSwap(string userid, int interested, char genre, int discoid, int offset);
        Task<bool> MatchEvaluation(string userorigin, string userlike);
        Task UnMatch(string userorigin, string userlike);
    }
}
