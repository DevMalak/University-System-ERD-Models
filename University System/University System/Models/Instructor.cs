using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University_System.Models
{
 public class Instructor
    {
        [Key] //primary key
        public int instructorId { get; set; } //system generated

        [Required]
        [MaxLength(100)]
        public string fullName { get; set; } //user input 

        [Required]
        [MaxLength(150)]
        public string email { get; set; } //user input 

        [MaxLength(20)]
        public string ? officeNumber { get; set; } //user input

        [Required]
        public DateTime hireDate { get; set; } //user input 

        [Required]
        [Range(1, 9999999)]
        public decimal salary { get; set; } //user input

        [Required]
        [MaxLength(50)]
        public string academicTitle { get; set; } //user input


        // --- Navigation Properties

        public virtual Department? HeadedDepartment { get; set; }
        public virtual ICollection<Course> Courses { get; set; }


    }
}
