using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentENF.Model02
{
    internal class Students
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "First Name is required.")]
        [StringLength(100,ErrorMessage ="First Name cannot be longer than 100 characters.")]
        public string? FName { get; set; }
        [Required(ErrorMessage = "Last Name is required.")]
        [StringLength(100, ErrorMessage = "Last Name cannot be longer than 100 characters.")]
        public string? LName { get; set; }
        [Required(ErrorMessage = "Age is required.")]
        [Range(1, 100, ErrorMessage = "Age must be between 1 and 100.")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Address is required.")]
        [StringLength(200, ErrorMessage = "Address cannot be longer than 200 characters.")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Department ID is required.")]
        public int Dept_id { get; set; }
    }
}
