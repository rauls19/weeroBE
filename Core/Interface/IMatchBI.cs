using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Model;

namespace Core.Interface
{
    public interface IMatchBI
    {
        Task<List<MatchDto>> GetListSwap(string userid, int interested, char genre, int discoid, int offset);
        Task<bool> MatchedUser(string userorigin, string userlike);
        Task UnMatchedUser(string userorigin, string userlike);
    }
}