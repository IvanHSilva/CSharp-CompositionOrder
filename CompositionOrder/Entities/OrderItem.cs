namespace CompositionOrder.Entities {
    public class OrderItem {
        // Attributes
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        // Constructors
        public OrderItem() { }

        public OrderItem(int quantity, double price, Product product) {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        // Methods
        public double SubTotal() {
            return Quantity * Price;
        }
    }
}
