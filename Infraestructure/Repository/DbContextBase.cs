using Microsoft.EntityFrameworkCore;
using Infraestructure.Entity;

namespace Infraestructure
{
    public class DbContextBase : DbContext
    {   
        public DbContextBase(DbContextOptions<DbContextBase> options) : base(options){}
    }
}



