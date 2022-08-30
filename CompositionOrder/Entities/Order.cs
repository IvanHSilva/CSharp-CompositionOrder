using CompositionOrder.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CompositionOrder.Entities {
    public class Order {
        // Attributes
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        

        // Constructors
        public Order() { }

        public Order(DateTime moment, OrderStatus status, Client client) {
            Moment = moment;
            Status = status;
            Client = client;
        }

        // Methods
        public void AddItem(OrderItem item) {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item) {
            Items.Remove(item);
        }

        public double Total() {
            double sum = 0.0;
            foreach (OrderItem item in Items) {
                sum += item.SubTotal();
            }
            return sum;
        }

        // ToString
        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Resumo do Pedido");
            sb.AppendLine($"Data: {Moment.ToString("dd/MM/yyyy HH:mm:ss")}");
            sb.AppendLine($"Status: {Status}");
            sb.AppendLine($"Cliente: {Client.Name} - {Client.EMail} ({Client.BirthDate.ToString("dd/MM/yyyy")})");
            sb.AppendLine("Itens do pedido");
            foreach (OrderItem item in Items) {
                sb.Append($"{item.Product.Name}, ${item.Price.ToString("F2", CultureInfo.InvariantCulture)}, ");
                sb.AppendLine($"Quantidade: {item.Quantity}, Subtotal: ${item.SubTotal().ToString("F2", CultureInfo.InvariantCulture)}");
            }
            sb.AppendLine($"Total geral: ${Total().ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}
