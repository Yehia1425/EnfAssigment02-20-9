using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentENF.Models
{
    internal class AirCarft_Routes
    {
        [Key]
        public int AC_Id { get; set; }

        [Required]
        public int Route_Id { get; set; }

        [Range(0,20,ErrorMessage = "Departure hour must be between 0 and 20")]
        public int Departure { get; set; }

        [Range(1, 70, ErrorMessage = "Number of passengers must be between 1 and 70.")]
        public int Num_Of_Pass { get; set; }
        [Range(50, 5000, ErrorMessage = "Price must be between 50 and 5000.")]
        public int price { get; set; }
        [Required(ErrorMessage = "Arrival is required.")]
        [StringLength(100, ErrorMessage = "Arrival cannot be longer than 100 characters.")]
        public string Arrival { get; set; }
    }
}
