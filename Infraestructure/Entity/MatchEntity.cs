using System;

namespace Infraestructure.Entity
{
    public class MatchEntity : BaseEntity
    {
        public string Name{ get; set; }
        public string Surname{ get; set; }
        //TODO: I don't know what the hell the logo's type is ...
        public int Age{ get; set; }
        public string Description{ get; set; }
    }
}
