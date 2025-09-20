using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentENF.Model02
{
    internal class Courses
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Duration is required")]
        [Range(1, 52, ErrorMessage = "Duration must be between 1 and 52 weeks")]
        public int Duration { get; set; }
        [Required(ErrorMessage = "Description is required")]
        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters")]
        public string? Description { get; set; }
        [Required(ErrorMessage = "Top_id is required")]
        public int Top_id { get; set; }
    }
}
