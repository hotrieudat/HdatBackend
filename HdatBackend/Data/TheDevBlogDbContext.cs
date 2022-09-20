using Microsoft.EntityFrameworkCore;

namespace HdatBackend.Data
{
    public class TheDevBlogDbContext : DbContext
    {
        public TheDevBlogDbContext(DbContextOptions options) : base(options)
        {

        }
        // DbSet
    }
}
