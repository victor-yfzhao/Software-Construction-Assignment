namespace OrderApi.Models
{
    public class OrderModel
    {
        public int OrderId { get; set; }
        public string? CustomerName { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<OrderDetailModel> OrderDetails { get; set; } = new List<OrderDetailModel>();
    }

    public class OrderDetailModel
    {
        public int DetailId { get; set; }
        public int OrderId { get; set; }
        public string? ItemName { get; set; }
        public double ItemValue { get; set; }
        public uint ItemQuantity { get; set; }

    }
}
