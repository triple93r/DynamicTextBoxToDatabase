using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<tblStudent> tblStudent { get; set; }
        public DbSet<tbl_Subject> tbl_Subject { get; set; }
        public DbSet<WebApplication1.Models.StudentClass>? StudentClass { get; set; }
        public DbSet<WebApplication1.Models.AllClass>? AllClass { get; set; }
    }
}
