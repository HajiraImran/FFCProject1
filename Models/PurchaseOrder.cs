using System;
using System.ComponentModel.DataAnnotations;

namespace FFCProject.Models
{
    public class PurchaseOrder
    {
        public int Id { get; set; }

        [Required]
        public string OrderNumber { get; set; }

        public string Description { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;

        // Add more fields as needed (e.g. VendorId, TotalAmount)
    }
}
