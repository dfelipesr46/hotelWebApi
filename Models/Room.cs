using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace hotelWebAPI.Models
{
    public class Room
    {
        [Key]
        [Column("id")]
        public int Id {get; set;}

        [Column("room_number")]
        [Required]
        public string? RoomNumber {get; set;}

        [Column("room_type_id")]
        [Required]
        [ForeignKey("RoomTypeId")]
        public int RoomTypeId {get; set;}

        [Column("price_per_night")]
        [Required]
        public double PricePerNight {get; set;}

        [Column("availability")]
        [Required]
        public bool Availability {get; set;}

        [Column("max_guests")]
        [Required]
        public double maxGuests {get; set;}

        public required RoomType RoomType { get; set; }
        public required ICollection<Booking> Bookings { get; set; }
    }
}