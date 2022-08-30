namespace CompositionOrder.Entities {
    public class Product {
        // Attributes
        public string Name { get; set; }
        public double Price { get; set; }

        // Constructors
        public Product() { }

        public Product(string name, double price) {
            Name = name;
            Price = price;
        }
    }
}
