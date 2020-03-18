using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interface
{
    public interface IUser
    {
        Task<string> Test();
    }
}