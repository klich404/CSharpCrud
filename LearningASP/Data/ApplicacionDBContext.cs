using LearningASP.Models;
using Microsoft.EntityFrameworkCore;

namespace LearningASP.Data
{
    public class ApplicacionDBContext : DbContext
    {
        public ApplicacionDBContext(DbContextOptions<ApplicacionDBContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
    }
}
