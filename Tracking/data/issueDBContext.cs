using Microsoft.EntityFrameworkCore;
using Tracking.models;

namespace Tracking.data
{
    public class issueDBContext : DbContext
    {
        public issueDBContext(DbContextOptions<issueDBContext> options)
               :base(options)
        {
        }
      public DbSet<issue>issues { get; set; }
    }
}
