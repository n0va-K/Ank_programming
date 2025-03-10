using System;
using NUnit.Framework;
using OrderLibrary;

namespace OrderLibrary.UnitTests
{
    [TestFixture]
    public class OrderUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var order = CreateTestOrder();

            Assert.That(order.ItemName, Is.EqualTo("iPhone"));
            Assert.That(order.ItemID, Is.EqualTo("0000"));
            Assert.That(order.CourierSurname, Is.EqualTo("Jobs"));
            Assert.That(order.OrderNumber, Is.EqualTo("1"));
            Assert.That(order.DeliveryDate.ToShortDateString, Is.EqualTo("07.03.2025"));
            Assert.That(order.Type, Is.EqualTo(OrderType.Urgent));
        }

        [Test]
        public void GetInfoTest()
        {
            var order = CreateTestOrder();
            var info = order.GetInfo();

            Assert.That(info.Length, Is.EqualTo(2));
            Assert.That(info[0], Is.EqualTo("iPhone \n 0000"));

            string expectedInfo = $"Название товара: iPhone\n" +
                                  $"Артикул товара: 0000\n" +
                                  $"Фамилия курьера: Jobs\n" +
                                  $"Номер заявки: 1\n" +
                                  $"Дата и время доставки: 07.03.2025\n" +
                                  $"Тип заказа: срочный";

            Assert.That(info[1], Is.EqualTo(expectedInfo));
        }

        private Order CreateTestOrder()
        {
            return new Order("iPhone", "0000", "Jobs", "1", "07.03.2025", OrderType.Urgent);
        }
    }
}
