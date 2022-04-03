using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNeighborhood.Infrastructure.Data
{
    public class Article
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [Column(TypeName ="date")]
        public DateTime DateCreated { get; set; } = DateTime.Today;

        
        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(5000)]
        public string Text { get; set; }


        public string? Picture { get; set; }


        [Required]
        public Guid AuthorId { get; set; }

        
        [ForeignKey(nameof(AuthorId))]
        public Author Author { get; set; }

        [Required]
        public IList<Comment> Comments { get; set; } = new List<Comment>();//добавено на моя глава


    }
}
