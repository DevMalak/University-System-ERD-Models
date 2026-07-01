using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace E_Commerce_System.Models
{
    public class Order
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int orderId { get; set; } // system generated

        [Required]
        [ForeignKey("User")]
        public int userId { get; set; } // foreign key

        [Required]
        public DateTime orderDate { get; set; } // system generated

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        [Range(0, double.MaxValue)]
        public decimal totalAmount { get; set; } // calculated

        [Required]
        [MaxLength(30)]
        public string status { get; set; } = "Pending"; // default value

        [Required]
        [MaxLength(300)]
        public string shippingAddress { get; set; } // user input

        [Required]
        [MaxLength(50)]
        public string paymentMethod { get; set; } // from list

        // Navigation Properties
        public virtual User User { get; set; }

        public virtual ICollection<OrderProduct> OrderProducts { get; set; }




    }
}
