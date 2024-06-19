using System.ComponentModel.DataAnnotations;

namespace Assignment1_Api.DTO
{
    public class OrderDetailRequest
    {
        [Required]
        public int OrderId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int UnitPrice { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
