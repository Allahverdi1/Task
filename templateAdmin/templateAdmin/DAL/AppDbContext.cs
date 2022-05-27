using Microsoft.EntityFrameworkCore;

namespace templateAdmin.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
