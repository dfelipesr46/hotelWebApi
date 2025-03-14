using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace hotelWebAPI.Models
{
    public class Employee
    {
        [Key]
        [Column("id")]
        public int Id {get; set;}

        [Column("name")]
        [Required]
        public string Name {get; set;}

        [Column("last_name")]
        [Required]
        public string LastName {get; set;}

        [Column("email")]
        [Required]
        [EmailAddress]
        public string Email {get; set;}

        [Column("identification")]
        [Required]
        public string Identification {get; set;}

        [Column("password")]
        [Required]
        [DataType(DataType.Password)]
        public string Password {get; set;}

        public required ICollection<Booking> Bookings { get; set; }

    }
}