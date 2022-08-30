using CompositionOrder.Entities;
using CompositionOrder.Entities.Enums;
using System;
using System.Globalization;

namespace CompositionOrder {
    internal class Program {
        static void Main(string[] args) {
            // Client data
            Console.WriteLine("Dados do cliente:");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("E-Mail: ");
            string email = Console.ReadLine();
            Console.Write("Data de nascimento: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, birthDate);
            Console.WriteLine();

            // Order data
            Console.WriteLine("Dados do pedido:");
            Console.Write("Status: ");
            OrderStatus status = (OrderStatus)Enum.Parse(typeof(OrderStatus), Console.ReadLine());
            Order order = new Order(DateTime.Now, status, client);
            Console.Write("Número de itens: "); 
            int n = int.Parse(Console.ReadLine());

            // OrderItems data
            for (int i = 0; i<n; i++) {
                Console.WriteLine($"Item {i+1}");
                Console.Write("Produto: ");
                string prod= Console.ReadLine();
                Console.Write("Preço: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantidade: ");
                int quantity = int.Parse(Console.ReadLine());
                Product product = new Product(prod, price);
                OrderItem item = new OrderItem(quantity, price, product);
                order.AddItem(item);
            }
            Console.WriteLine();

            // Order summary
            Console.WriteLine(order);
        }
    }
}
