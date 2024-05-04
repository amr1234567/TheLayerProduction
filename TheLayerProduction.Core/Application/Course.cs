using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TheLayerProduction.Core.Identity;

namespace TheLayerProduction.Core.Application
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        [MinLength(3)]
        public string Name { get; set; }

        public List<Teacher> Teachers { get; set; } = [];
    }
}