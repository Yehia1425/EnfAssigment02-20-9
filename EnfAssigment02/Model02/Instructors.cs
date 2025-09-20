using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentENF.Model02
{
    internal class Instructors
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50,ErrorMessage =" Name length can't be more than 50.")]
        public string? Name { get; set; }
        [StringLength(100,ErrorMessage = " Address length can't be more than 100.")]
        public string? Address { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Bouns { get; set; }
        [Required(ErrorMessage = "Salary is required")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Salary { get; set; }
        [Required(ErrorMessage = "Hour Rate is required")]
        [DataType(DataType.Date)]
        [Range(0.01, 1000, ErrorMessage = "Hour rate must be between 0.01 and 1000.")]
        public DateTime Hour_Rate { get; set; }
        [Required(ErrorMessage = "Department ID is required")]
        public int Dep_Id { get; set; }


    }
}
