using Microsoft.EntityFrameworkCore;
using NguyenVietPhuong469.Models;
#nullable disable
namespace NguyenVietPhuong469.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<CompanyNVP469> CompanyNVP469s { get; set; }
    }
}
