using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using TheLayerProduction.Core.Identity;

namespace TheLayerProduction.Core.Application
{
    public class Package
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        [MinLength(3)]
        public string Name { get; set; }

        [Required]
        [Range(100, double.MaxValue)]
        public double PackagePrice { get; set; }

        public Teacher Teacher { get; set; } = new Teacher();

        [Required]
        [ForeignKey(nameof(Teacher))]
        public string TeacherId { get; set; }

        public List<Student> Students { get; set; } = [];
    }
}