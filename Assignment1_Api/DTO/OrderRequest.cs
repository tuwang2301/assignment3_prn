namespace Assignment1_Api.DTO
{
    public class OrderRequest
    {
        public int StaffId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public int Price { get; set; }
    }
}
