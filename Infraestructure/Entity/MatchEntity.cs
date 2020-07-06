using System;

namespace Infraestructure.Entity
{
    public class MatchEntity : BaseEntity
    {
        public string Name{ get; set; }
        public string Surname{ get; set; }
        public int Age{ get; set; }
        public string Description{ get; set; }
    }
}
