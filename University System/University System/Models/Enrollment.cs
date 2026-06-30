using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University_System.Models
{
   public class Enrollment
    {

        [Key]//primary key
        public int enrollmentId { get; set; } //system generated

        [Required]
        public int studentId { get; set; } //Foreign Key

        [Required]
        public int courseId { get; set; } //Foreign Key

        [Required]
        public DateTime enrollmentDate { get; set; } //user input 

        [MaxLength(2)]
        public string? finalGrade { get; set; } // user input 

        [Required]
        [MaxLength(20)]
        public string status { get; set; } //default value

        // Navigation Properties

        [ForeignKey("studentId")]
        public virtual Student Student { get; set; }


        [ForeignKey("courseId")]
        public virtual Course Course { get; set; }




    }
}
