using System;
using System.Collections;
using System.Collections.Generic;

namespace OrderLibrary
{
    public class Delivery : IEnumerable<Order>
    {
        public string CourierSurname { get; set; }
        public DateTime DeliveryDate;
        private List<Order> orders;

        public int Count { get => orders.Count; }

        public Delivery(string courierSurname, string deliveryDate, IEnumerable<Order> orderCollection)
        {
            CourierSurname = courierSurname;
            DeliveryDate = DateTime.Parse(deliveryDate);
            orders = new List<Order>();

            foreach (var order in orderCollection)
            {
                if (order.CourierSurname == courierSurname &&
                    order.DeliveryDate.Date == DeliveryDate.Date &&
                    !orders.Contains(order))
                {
                    orders.Add(order);
                }
            }
        }

        public IEnumerator<Order> GetEnumerator() => orders.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}