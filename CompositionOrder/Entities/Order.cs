using CompositionOrder.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionOrder.Entities {
    public class Order {
        // Attributes
        public DateTime Moment { get; set; }
        public OrderStatus  Status{ get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        // Constructors
        public Order() {}

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
    }
}
