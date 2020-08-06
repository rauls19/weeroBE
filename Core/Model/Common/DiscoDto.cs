using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Model
{
    public class DiscoDto
    {
        public long identifier { get; set; }
        public string position { get; set; }
        public string Name{ get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Logo { get; set; }
    }
}