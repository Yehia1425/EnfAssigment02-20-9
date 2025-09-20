using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentENF.Models
{
    internal class AirLine
    {
        [Key]
        public int AirLineId { get; set; }
        [Required(ErrorMessage = "Airline name is required.")]
        [StringLength(100, ErrorMessage = "Airline name cannot exceed 100 characters.")]
        public string? AirLineName { get; set; }
        [StringLength(100, ErrorMessage = "Country Address cannot exceed 100 characters.")]
        public string? ContactAddress { get; set; }
        [Required(ErrorMessage = "Contact Person_ID is required.")]
        public int Cont_Person { get; set; }
    }
}
