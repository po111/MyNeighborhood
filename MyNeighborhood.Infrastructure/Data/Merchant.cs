using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNeighborhood.Infrastructure.Data
{
    public class Merchant
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public string TradeName { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime DateCreated { get; set; } = DateTime.Today;

        [Required]
        public Type Type { get; set; }

        [Required]
        [StringLength(1000)]
        public string Description { get; set; }

        [Required]
        [StringLength(200)]
        public string Address { get; set; }


        //user - author

        //map

        //public byte[] Picture { get; set; }

    }
}
