namespace Product_Management.Models
{
    public class AddProductRequestDTO
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductCategory { get; set; }
        public int ProductQTY { get; set; }
    }
}
