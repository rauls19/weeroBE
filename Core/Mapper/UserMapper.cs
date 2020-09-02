using Core.Model;
using Infraestructure.Entity;

namespace Core.Mapper
{
    public static class UserMapper
    {
        public static UserEntity DtoEntity(this UserDto user)
        {
            if (user == null)
                return null;
            return new UserEntity {
                Name = user.Name,
                Surname = user.Surname,
                Hashid = user.Hashid,
                Birthday = user.Birthday,
                Password = user.Password,
                Phonenumber = user.Phonenumber,
                Extension = user.Extension,
                Genre = user.Genre,
                City = user.City
            };
        }
        public static UserEntity DtoProfileEntity(this UserDto user)
        {
            if (user == null)
                return null;
            return new UserEntity {
                Hashid = user.Hashid,
                Birthday = user.Birthday,
                Description = user.Description,
                City = user.City,
                Language = user.Language
            };
        }
         public static UserEntity EntityPersonalInfoDto(this UserDto user){
            if(user == null)
                return null;
            return new UserEntity {
                Hashid = user.Hashid,
                Name = user.Name,
                Surname = user.Surname,
                Email = user.Email,
                Phonenumber = user.Phonenumber,
                Extension = user.Extension,
                Genre = user.Genre
            };
        }
        //----------
        public static UserDto EntityDto(this UserEntity entity)
        {
            if (entity == null)
                return null;
            return new UserDto {
                Hashid = entity.Hashid,
                Name = entity.Name,
                Surname = entity.Surname,
                Birthday = entity.Birthday.Split(' ')[0],
                Email = entity.Email,
                Password = entity.Password,
                Age = entity.Age,
                Interested = entity.Interested,
                Location = entity.Location,
                City = entity.City,
                Description = entity.Description,
                Extension = entity.Extension,
                Phonenumber = entity.Phonenumber,
                Language = entity.Language,
                Disco = entity.Disco,
                Genre = entity.Genre,
            };
        }
         public static UserProfile EntityProfileDto(this UserEntity entity)
         {
            if (entity == null)
                return null;
            return new UserProfile {
                Name = entity.Name,
                Surname = entity.Surname,
                Hashid = entity.Hashid,
                Age = entity.Age,
                Description = entity.Description,
                Language = entity.Language,
                City = entity.City
            };
        }
    }
}
