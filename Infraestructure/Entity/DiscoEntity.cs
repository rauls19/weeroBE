using System;

namespace Infraestructure.Entity
{
    public class DiscoEntity : BaseEntity
    {
        public string Name{ get; set; }
        public string Location{ get; set; }
        //TODO: I don't know what the hell the logo's type is ...
        public string Logo{ get; set; }
        public string Street{ get; set; }
        public string City { get; set; }
    }
}
