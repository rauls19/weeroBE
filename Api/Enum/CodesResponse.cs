using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api
{
    enum CodesResponse
    {
        Ok = 200,
        BadRequest = 400,
        Unauthorized = 401,
        Notfound = 404,
        InternalError = 500        
    }
}