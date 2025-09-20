using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentENF.Models
{
    internal class AirCraft
    {
        [Key]
        public int Id { get; set; }
        [Range(1,200, ErrorMessage = "Capacity must be between 1 and 200.")]
        public int Capacity { get; set; }
        [Required(ErrorMessage = "Model is required.")]
        [StringLength(100, ErrorMessage = "Model cannot be longer than 100 characters.")]
        public string Model { get; set; }
        [Required(ErrorMessage = "MajPilot is required.")]
        public int MajPilot { get; set; }
        [StringLength(80)]
        public string Assistant { get; set; }
        [Required]
        public int Host01 { get; set; }
        [Required]
        public int Host02 { get; set; }
        [Required(ErrorMessage = "Airline ID is required.")]
        [StringLength(10, ErrorMessage = "Airline ID cannot be longer than 10 characters.")]
        public string Al_Id { get; set; }




    }
}
