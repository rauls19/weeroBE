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
                
            };
        }
        public static UserDto EntityDto(this UserEntity entity)
        {
            if (entity == null)
            {
                return null;
            }
            return new UserDto {
                
            };
        }
    }
}
