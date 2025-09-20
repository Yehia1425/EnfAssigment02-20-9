using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentENF.Models
{
    internal class Route
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Distance is required")]
        [StringLength(50, ErrorMessage = "Distance cannot be longer than 50 characters")]
        public string? Distance { get; set; }
        [Required(ErrorMessage = "Duration is required")]
        [StringLength(50, ErrorMessage = "Duration cannot be longer than 50 characters")]
        public string? Destination { get; set; }
        [Required(ErrorMessage = "Origin is required")]
        [StringLength(50, ErrorMessage = "Origin cannot be longer than 50 characters")]
        public string? Origin { get; set; }
        [Required(ErrorMessage = "Classification is required")]
        [StringLength(50, ErrorMessage = "Classification cannot be longer than 50 characters")]
        public string? Classification { get; set; }

    }
}
