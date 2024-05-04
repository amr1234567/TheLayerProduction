using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TheLayerProduction.Core.Application
{
    public class Lesson
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        [MinLength(3)]
        public string Name { get; set; }

        [Url]
        public string? PdfLink { get; set; }

        [Required]
        [Url]
        public string VideoLink { get; set; }

        [ForeignKey(nameof(Package))]
        public int PackageId { get; set; }

        public Package Package { get; set; } = new Package();
    }
}