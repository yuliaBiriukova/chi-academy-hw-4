using HW_4.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HW_4.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<ASPDeveloper> Developer { get; set; }
    }
}