using Assignment1_Api.Models;

namespace Assignment1_Client.Models
{
    public class SearchViewModel
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
