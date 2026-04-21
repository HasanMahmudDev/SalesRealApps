using System.ComponentModel.DataAnnotations;

namespace SalesRealApp.Models
{
    public class Sale
    {
        public int Id { get; set; }

        [Required]
        public string CustomerName { get; set; }

        public decimal Price { get; set; }
        public DateTime SaleDate { get; set; }
    }
}
