using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace University_System.Models
{

    public class Course
    {
        [Key] // primary key
        public int courseId { get; set; } // system generated

        [Required]
        [MaxLength(10)]
        public string courseCode { get; set; }  //user input 

        [Required]
        [MaxLength(150)]
        public string courseTitle { get; set; } //user input 

        [Required]
        [Range(1, 6)]
        public int creditHours { get; set; } //user input 

        [Required]
        [MaxLength(20)]
        public string semesterOffered { get; set; } // user input

        [Required]
        public int departmentId { get; set; } //Foreign Key

        public int? instructorId { get; set; } //foreign key


        // Navigation Properties 

        [ForeignKey("departmentId")]
        public virtual Department Department { get; set; }

        [ForeignKey("instructorId")]
        public virtual Instructor? Instructor { get; set; }
    }
}
