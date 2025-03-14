using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace hotelWebAPI.Models
{
    public class RoomType
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        [Required]
        public string? Name { get; set; }

        [Column("description")]
        public string? Description { get; set; }

        public required ICollection<Room> Rooms { get; set; }

    }
}