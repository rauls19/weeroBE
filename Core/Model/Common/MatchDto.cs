using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Model
{
    public class MatchDto
    {
        public string Name { get; set; }
        public string Surname{ get; set; }
        public int Age { get; set; }
        public string Description { get; set; }
        public string Identifier { get; set; }
    }
}