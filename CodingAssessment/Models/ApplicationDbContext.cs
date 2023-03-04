using Microsoft.EntityFrameworkCore;

namespace CodingAssessment.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)

        {

        }
        public DbSet<CarModel> cars { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        //private void ModelConfig(ModelBuilder builder)
        //{
        //    new PersonConfiguration(builder.Entity<PersonOI>());
        //}

    }

}