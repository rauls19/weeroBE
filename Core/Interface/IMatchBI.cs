using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Model;

namespace Core.Interface
{
    public interface IMatchBI
    {
        Task<List<MatchDto>> GetListSwap(string userid, int interested, char genre, int discoid, int offset);
        Task<bool> MatchedUser(int userorigin, int userlike);
        Task UnMatchedUser(int userorigin, int userlike);
    }
}