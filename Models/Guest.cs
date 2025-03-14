using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace hotelWebAPI.Models
{
    public class Guest
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
        [EmailAddress]
        [Required]
        public string Email {get; set;}

        [Column("identification_number")]
        [Required]
        public string IdentificationNumber {get; set;}

        [Column("phone_number")]
        [Required]
        [Phone]
        public string PhoneNumber {get; set;}

        [Column("birth_date")]
        [Required]
        [DataType(DataType.Date)]
        public DateOnly BirthDate {get; set;}

        public required ICollection<Booking> Bookings { get; set; }
    }
}