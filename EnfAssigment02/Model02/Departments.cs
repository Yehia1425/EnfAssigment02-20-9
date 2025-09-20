using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentENF.Model02
{
    internal class Departments
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Department Name is required")]
        public string? DeptName { get; set; }
        [Required(ErrorMessage = "Location is required")]
        [DataType(DataType.Date)]
        public DateTime Hiring_Date { get; set; }
        [Required(ErrorMessage = "Instructor Id is required")]
        public int Ins_Id { get; set; }
    }
}
