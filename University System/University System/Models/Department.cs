using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema;

namespace University_System.Models
{
    public class Department
    {
        [Key]// primary key
        public int departmentId { get; set; } //system generated


        [Required] 
        [MaxLength(100)]
        public string departmentName { get; set; } //user input

        [MaxLength(50)]
        public string? building { get; set; } //user input 

        [Required]
        [Range(0, 99999999)]
        public  decimal budget { get; set; }  //user input


       public int? headInstructorId { get; set; } //Foreign Key

        // Navigation Properties ---

        [ForeignKey("headInstructorId")]
        public virtual Instructor? HeadInstructor { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
