using System.Collections.Generic;

namespace Core.Model
{
    public class UserProfile
    {
        public string Hashid{ get; set; }
        public string Name{ get; set; }
        public string Surname{ get; set; }
        public int Age{ get; set; }
        public string Description{ get; set; }
        public List<string> Language { get; set; } 
    }
}