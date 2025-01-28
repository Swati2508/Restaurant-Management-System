namespace RestaurantManagement.Order
{
    public class Orders
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string OrderName { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
