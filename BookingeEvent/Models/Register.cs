using System.ComponentModel.DataAnnotations;

namespace BookingEvent.Models
{
    //Register Model Class
    public class Register
    {
        [Key] 
        public int RegisterId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Surname {  get; set; }
        public string Email { get; set; }
        public string Username {  get; set; }
        public string Password { get; set; }
    }
}
