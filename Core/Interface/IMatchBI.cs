using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Model;

namespace Core.Interface
{
    public interface IMatchBI
    {
        Task<List<DiscoDto>> GetListSwap(int userid, int interested, char genre, int discoid, int offset);
    }
}