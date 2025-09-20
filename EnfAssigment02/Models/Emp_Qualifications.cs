using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentENF.Models
{
    internal class Emp_Qualifications
    {
        [Key]
        public int Emp_id { get; set; }
        [Required(ErrorMessage = "Qualifications are required.")]
        [StringLength(100, ErrorMessage = "Qualifications cannot exceed 100 characters.")]
        public string Qualifications { get; set; }

    }
}
