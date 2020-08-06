using Core.Model;
using Infraestructure.Entity;

namespace Core.Mapper
{
    public static class UserMapper
    {
        public static UserEntity DtoEntity(this UserDto user)
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
        }
        public static UserDto EntityDto(this UserEntity entity)
        {
            if (entity == null)
            {
                return null;
            }
            return new UserDto {
                Name = entity.Name,
                Surname = entity.Surname,
                Hashid = entity.Hashid,
                Birthday = entity.Birthday.Split(' ')[0],
                Age = entity.Age,
                Description = entity.Description,
                Disco = entity.Disco,
                Email = entity.Email,
                Extension = entity.Extension,
                Phonenumber = entity.Phonenumber,
                Genre = entity.Genre,
                Interested = entity.Interested,
                Language = entity.Language,
            };
        }
    }
}
