using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Model
{
    public class UserDto
    {
        public string Hashid{ get; set; }
        public string Name{ get; set; }
        public string Surname{ get; set; }
        public string Birthday{ get; set; }
        public string Email{ get; set; }
        public string Password{ get; set; }
        public int Age{ get; set; }
        public int Interested{ get; set; }
        public string Location{ get; set; }
        public string Description{ get; set; }
        public int Extension{ get; set; }
        public int Phonenumber{ get; set; }
        public List<string> Language { get; set; } 
        public string Disco{ get; set;}
        public string Genre { get; set; }
    }
}