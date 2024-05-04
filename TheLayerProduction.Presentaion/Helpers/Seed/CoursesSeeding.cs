using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheLayerProduction.Core.Application;

namespace TheLayerProduction.Presentaion.Helpers.Seed
{
    public static class CoursesSeeding
    {
        public static void SeedCourses(this ModelBuilder model)
        {
            model.Entity<Course>().HasData(
            new Course
            {
                Id = 1000,
                Name = "Arabic"
            },
            new Course
            {
                Id = 1001,
                Name = "English"
            },
            new Course
            {
                Id = 1002,
                Name = "Math"
            },
            new Course
            {
                Id = 1003,
                Name = "Physics"

            },
            new Course
            {
                Id = 1004,
                Name = "Anatomy"
            }
            );
        }
    }
}
