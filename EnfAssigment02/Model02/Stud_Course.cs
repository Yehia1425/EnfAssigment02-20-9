using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentENF.Model02
{
    internal class Stud_Course
    {
        [Key]
        public int StudentId { get; set; }
        [Required(ErrorMessage = "CourseId is required.")]
        public int CourseId { get; set; }
        [Required(ErrorMessage = "Grade is required.")]
        [Range(0, 100, ErrorMessage = "Grade must be between 0 and 100.")]
        public int Grade { get; set; }
    }
}
