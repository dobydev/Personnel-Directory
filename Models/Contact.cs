using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Contact
    {
        public int Id { get; set; }

        public string Department { get; set; } = ""; // "Administration", "Communications", etc.

        [Display(Name = "First Name")]
        public string FirstName { get; set; } = "";
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = "";
        public string? Title { get; set; }
        [Display(Name = "Direct Dial")]
        public string? DirectDial { get; set; }
        public string? Extension { get; set; }
        [Display(Name = "Room Number")]
        public string? RoomNumber { get; set; }
        // Added for more convenience to end users
        [Display(Name = "Email")]
        public string? Email {  get; set; }

        public Contact()
        {
                // left empty on purpose
        }
    }
}
