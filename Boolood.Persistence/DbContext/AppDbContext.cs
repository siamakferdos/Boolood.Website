using Boolood.Model.DbModels;
using Microsoft.EntityFrameworkCore;

namespace Boolood.Persistence.DbContext
{
    public class AppDbContext: Microsoft.EntityFrameworkCore.DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Boolood");
            
        }
      
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Language> Languages{ get; set; }
        public DbSet<Article> Articles { get; set; }
    }
}
