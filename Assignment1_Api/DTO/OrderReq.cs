using System.ComponentModel.DataAnnotations;

namespace Assignment1_Api.DTO
{
    public class OrderReq
    {
        public int OrderId { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
   
        [Required]
        public int MemberId { get; set; }
    }
}
