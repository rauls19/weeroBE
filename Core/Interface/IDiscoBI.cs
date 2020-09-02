using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Model;

namespace Core.Interface
{
    public interface IDiscoBI
    {
        Task<List<DiscoDto>> GetListDisco(int maxresults, int offset);
        Task ChangeDiscoParty(long request, string identifier);
    }
}