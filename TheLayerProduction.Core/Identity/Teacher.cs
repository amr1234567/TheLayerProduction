using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TheLayerProduction.Core.Application;
using TheLayerProduction.Core.Identity.Base;

namespace TheLayerProduction.Core.Identity
{
    public class Teacher : Consumer
    {
        public Course Course { get; set; } = new Course();

        [Required]
        [ForeignKey(nameof(Course))]
        public int CourseId { get; set; }

        public List<Package> Packages { get; set; } = [];
        public List<Post> Posts { get; set; } = [];
    }
}