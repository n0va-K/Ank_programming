using System;
using System.Xml.Linq;

namespace OrderLibrary
{
    public class Order: IComparable<Order>
    {
        public string ItemName { get; set; }
        public readonly string ItemID;
        public string CourierSurname { get; set; }
        public readonly string OrderNumber;
        public DateTime DeliveryDate { get; set; }
        public OrderType Type { get; set; }

        public Order(string itemName, string itemID, string courierSurname, string orderNumber)
        {
            ItemName = itemName;
            ItemID = itemID;
            CourierSurname = courierSurname;
            OrderNumber = orderNumber;
        }

        public virtual string[] GetInfo()
        {
            var info = new string[2];
            info[0] = $"{ItemName} \n {ItemID}";

            string type = Type == OrderType.Standard ? "обычный" : "срочный";

            info[1] = $"Название товара: {ItemName}\n" +
                      $"Артикул товара: {ItemID}\n" +
                      $"Фамилия курьера: {CourierSurname}\n" +
                      $"Номер заявки: {OrderNumber}\n" +
                      $"Дата и время доставки: {DeliveryDate:d}\n" +
                      $"Тип заказа: {type}";
            return info;
        }

        public int CompareTo(Order other)
        {
            if (CourierSurname != other.CourierSurname)
                return CourierSurname.CompareTo(other.CourierSurname);
            else if (Type != other.Type)
                return Type.CompareTo(other.Type);
            else
                return DeliveryDate.CompareTo(other.DeliveryDate);
        }
    }
}