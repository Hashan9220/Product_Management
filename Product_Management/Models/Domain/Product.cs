namespace Product_Management.Models.Domain
{
    public class Product
    {
        public Guid Id { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductCategory { get; set; }
        public int ProductQTY { get; set; }
    }
}
