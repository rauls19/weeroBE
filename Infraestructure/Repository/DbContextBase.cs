using Microsoft.EntityFrameworkCore;

namespace Infraestructure
{
    public class DbContextBase : DbContext
    {   
        public DbContextBase(DbContextOptions<DbContextBase> options) : base(options){}
    }
}



