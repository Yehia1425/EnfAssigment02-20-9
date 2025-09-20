using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentENF.Models
{
    internal class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(25,ErrorMessage = "Name cannot be longer than 50 characters")]
        public string? Name { get; set; }
        [StringLength(100,ErrorMessage = "Address cannot exceed 100 characters")]
        public string? Address { get; set; }
        [Required]
        public char Gender { get; set; }
        [StringLength(100,ErrorMessage = "Position cannot exceed 100 characters")]
        public string? Position { get; set; }
        [Required]
        public DateTime BD_Year { get; set; }
        [Required]
        [DataType(DataType.Date)]

        public DateTime BD_Month { get; set; }
        [Required]
        [DataType(DataType.Date)]

        public DateTime BD_Day { get; set; }
        [Required]
        [DataType(DataType.Date)]

        public int Al_Id { get; set; }


    }
}
