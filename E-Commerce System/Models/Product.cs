using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce_System.Models
{
    public class Product
    {


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int productId { get; set; } // system generated

        [Required]
        [MaxLength(150)]
        public string productName { get; set; } // user input

        [MaxLength(1000)]
        public string description { get; set; } // user input

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        [Range(0.01, double.MaxValue)]
        public decimal price { get; set; } // user input

        [Required]
        [Range(0, int.MaxValue)]
        public int stockQuantity { get; set; } = 0; // default value

        [MaxLength(300)]
        public string imageUrl { get; set; } // user input

        [Required]
        [ForeignKey("Category")]
        public int categoryId { get; set; } // foreign key

        [Required]
        public DateTime createdAt { get; set; } // system generated

        public bool isAvailable { get; set; } = true; // default value

        // Navigation Properties
        public virtual Category Category { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }

        public virtual ICollection<OrderProduct> OrderProducts { get; set; }





    }
}
