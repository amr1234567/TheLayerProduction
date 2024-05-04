

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TheLayerProduction.Core.Application;
using TheLayerProduction.Core.Dto;
using TheLayerProduction.Core.Identity;
using TheLayerProduction.Core.Identity.Base;
using TheLayerProduction.Presentaion.Helpers.Seed;

namespace TheLayerProduction.Presentaion.Context
{
    public class TheLayerContext : IdentityDbContext<Consumer>
    {
        public TheLayerContext(DbContextOptions<TheLayerContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Post> Posts { get; set; }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.HasDefaultSchema("Security");
            builder.Entity<Course>()
                .ToTable("Courses", "App");
            builder.Entity<Lesson>()
                .ToTable("Lessons", "App");
            builder.Entity<Package>()
                .ToTable("Packages", "App");
            builder.Entity<Post>()
                .ToTable("Posts", "App");
            builder.Entity<Admin>();
            builder.Entity<Student>();
            builder.Entity<Teacher>();
            builder.Entity<Consumer>().ToTable("Consumers");

            builder.SeedCourses();
            builder.SeedRoles();
        }
    }
}
