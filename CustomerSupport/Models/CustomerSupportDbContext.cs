using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CustomerSupport.Models
{
    public class CustomerSupportDbContext : IdentityDbContext<IdentityUser>
    {
        public CustomerSupportDbContext(DbContextOptions<CustomerSupportDbContext> options) : base(options)
        {

        }

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
