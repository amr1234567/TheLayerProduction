using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using TheLayerProduction.Core.Identity;

namespace TheLayerProduction.Core.Application
{
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public Teacher Teacher { get; set; } = new Teacher();

        [Required]
        [ForeignKey(nameof(Teacher))]
        public string TeacherId { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public string Content { get; set; }
    }
}