using System;

namespace Infraestructure.Entity
{
    public class DiscoEntity : BaseEntity
    {
        public string Name{ get; set; }
        public string Location{ get; set; }
        //TODO: I don't know what the hell is the logo's type
        public string Logo{ get; set; }
    }
}
