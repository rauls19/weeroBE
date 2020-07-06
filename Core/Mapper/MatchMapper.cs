using Core.Model;
using Infraestructure.Entity;
using System.Collections.Generic;

namespace Core.Mapper
{
    public static class MatchMapper
    {
        public static List<MatchEntity> DtoEntity(this MatchDto disco)
        {
            if (disco == null)
            {
                return null;
            }
            return new List<MatchEntity>() {
                
            };
        }
        public static List<MatchDto> EntityDto(this List<MatchEntity> entity)
        {
            if (entity == null)
            {
                return null;
            }
            var matchlist = new List<MatchDto>();
            foreach ( var ent in entity)
            {
                matchlist.Add(new MatchDto(){
                    Name = ent.Name,
                    Surname = ent.Surname,
                    Age = ent.Age,
                    Description = ent.Description
                });
            }
            return matchlist;
        }
    }
}
