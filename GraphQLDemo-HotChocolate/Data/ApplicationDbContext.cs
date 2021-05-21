using Microsoft.EntityFrameworkCore;

namespace GraphQLDemo_HotChocolate.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {

        }

        public DbSet<Speaker> Speakers { get; set; }
    }
}
