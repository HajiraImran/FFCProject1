using System.ComponentModel.DataAnnotations;

namespace FFCProject.Models
{
    public class Vendor
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string ContactPerson { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        // Add more fields if needed
    }
}
