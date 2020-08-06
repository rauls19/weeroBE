using Core.Model;
using Infraestructure.Entity;

namespace Core.Mapper
{
    public static class ProfileMapper
    {
        /*public static UserEntity DtoEntity(this UserDto user)
        {
            if (user == null)
            {
                return null;
            }
            return new UserEntity {
                Name = user.Name,
                Surname = user.Surname,
                Hashid = user.Hashid,
                Birthday = user.Birthday,
                Password = user.Password,
                Age = user.Age,
                Phonenumber = user.Phonenumber,
                Extension = user.Extension,
                Genre = user.Genre
            };
        }*/
         public static UserProfile EntityDto(this UserEntity entity)
        {
            if (entity == null)
            {
                return null;
            }
            return new UserProfile {
                Name = entity.Name,
                Surname = entity.Surname,
                Hashid = entity.Hashid,
                Age = entity.Age,
                Description = entity.Description,
                Language = entity.Language
            };
        }
    }
}
