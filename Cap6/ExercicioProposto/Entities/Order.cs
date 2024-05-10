using System.Text;
using CursoDeCsharp.Cap6.Aulas.ExercicioProposto.Entities.Enums;

namespace CursoDeCsharp.Cap6.Aulas.ExercicioProposto.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0;
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.Append("Order Moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order Status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.Append(Client.Name + " ");
            sb.Append(Client.BirthDate.ToString("(dd/MM/yyyy)"));
            sb.AppendLine(" - " + Client.Email);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.Product.Name + ", Price: R$ "+ item.Price.ToString("F2") + ", Quantity: " + item.Quantity.ToString()
                + ", SubTotal: R$ " + item.SubTotal().ToString("F2"));
            }
            sb.AppendLine("Total Price:");
            sb.AppendLine(Total().ToString("F2"));

            return sb.ToString();
        }
    }
}