using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce_System.Models
{

    [PrimaryKey(nameof(OrderId), nameof(ProductId))]
    public class OrderProduct
    {

        [Required]
        [ForeignKey("Order")]
        public int OrderId { get; set; } // foreign key

        [Required]
        [ForeignKey("Product")]
        public int ProductId { get; set; } // foreign key

        [Required]
        [Range(1, 999)]
        public int Quantity { get; set; } // user input

        // Navigation
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }



    }
}
