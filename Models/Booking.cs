using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace hotelWebAPI.Models
{
    public class Booking
    {
        [Key]
        [Column("id")]
        public int Id {get; set;}

        [Column("room_id")]
        [Required]
        [ForeignKey("RoomId")]
        public int RoomId {get; set;}

        [Column("guest_id")]
        [Required]
        [ForeignKey("GuestId")]
        public int GuestId {get; set;}

        [Column("employee_id")]
        [Required]
        [ForeignKey("EmployeeId")]
        public int EmployeeId {get; set;}

        [Column("check_in")]
        [Required]
        public DateTime CheckIn {get; set;}

        [Column("check_out")]
        [Required]
        public DateTime CheckOut {get; set;}

        [Column("total_price")]
        [Required]
        public double TotalPrice {get; set;}

        public required Room Room { get; set; }
        public required Guest Guest { get; set; }
        public required Employee Employee { get; set; }
    }
}