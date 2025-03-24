using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BookingEvent.Models
{
    public class Venue
    {
        [Key]
        public int VenueId { get; set; }
        [Required]
        [DisplayName("Venue Name")]
        public string VenueName { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }
        public string ImageUrl { get; set; }

        public ICollection<Event> Events { get; set; }
    }
}
