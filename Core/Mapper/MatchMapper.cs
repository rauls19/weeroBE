using Core.Model;
using Infraestructure.Entity;
using System.Collections.Generic;

namespace Core.Mapper
{
    public static class MatchMapper
    {
        public static List<MatchEntity> DtoEntity(this DiscoDto disco)
        {
            if (disco == null)
            {
                return null;
            }
            return new List<MatchEntity>() {
                
            };
        }
        public static List<DiscoDto> EntityDto(this List<MatchEntity> entity)
        {
            if (entity == null)
            {
                return null;
            }
            var disclist = new List<DiscoDto>();
            foreach ( var ent in entity)
            {
                disclist.Add(new DiscoDto(){
                    //position = ent.Location,
                    //Name = ent.Name,
                    //Street = ent.Street,
                    //City = ent.City
                });
            }
            return disclist;
        }
    }
}
