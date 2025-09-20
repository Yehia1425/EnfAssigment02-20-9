using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentENF.Model02
{
    internal class Course_Instructor
    {
        [Key]
        public int CourseId { get; set; }
        [Required(ErrorMessage = "InstructorId is required")]
        public int InstructorId { get; set; }
        [StringLength(500, ErrorMessage = "Evaluation cannot exceed 500 characters")]
        public string? Evaluation { get; set; }
    }
}
