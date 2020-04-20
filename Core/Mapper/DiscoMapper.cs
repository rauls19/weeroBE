using Core.Model;
using Infraestructure.Entity;
using System.Collections.Generic;

namespace Core.Mapper
{
    public static class DiscoMapper
    {
        public static DiscoEntity DtoEntity(this DiscoDto disco)
        {
            if (disco == null)
            {
                return null;
            }
            return new DiscoEntity {
                
            };
        }
        public static List<DiscoDto> EntityDto(this List<DiscoEntity> entity)
        {
            if (entity == null)
            {
                return null;
            }
            var disclist = new List<DiscoDto>();
            foreach ( var ent in entity)
            {
                disclist.Add(new DiscoDto(){
                    position = ent.Location,
                    Name = ent.Name
                });
            }
            return disclist;
        }
    }
}
