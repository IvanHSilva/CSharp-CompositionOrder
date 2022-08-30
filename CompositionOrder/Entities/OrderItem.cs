namespace CompositionOrder.Entities {
    public class OrderItem {
        // Attributes
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        // Constructors
        public OrderItem() { }

        public OrderItem(int quantity, double price) {
            Quantity = quantity;
            Price = price;
        }

        // Methods
        public double SubTotal() {
            return Quantity * Price;
        }
    }
}
