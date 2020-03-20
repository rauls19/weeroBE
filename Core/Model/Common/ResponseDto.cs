using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Model
{
    public class ResponseDto
    {
        public int Code { get; set; }
        public object Result { get; set; }
    }
}