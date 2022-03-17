using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNeighborhood.Infrastructure.Data
{
    public class Comment
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public Guid ArticleId { get; set; }

        [ForeignKey(nameof(ArticleId))]
        public Article Article { get; set; }

        [Required]
        [StringLength(500)]
        public string Content { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; } = DateTime.Today;

    }
}
