using System;
using NUnit.Framework;
using OrderLibrary;
using static OrderLibrary.UrgentOrder;

namespace OrderLibrary.UnitTests
{
    [TestFixture]
    public class UrgentOrderUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var order = CreateTestUrgentOrder();

            Assert.That(order.UrgencyCoefficient, Is.EqualTo(1.5));
            Assert.That(order.UrgencyLevel, Is.EqualTo(UrgencyType.WithinThreeHours));
        }

        [Test]
        public void GetInfoTest()
        {
            var order = CreateTestUrgentOrder();
            var info = order.GetInfo();

            Assert.That(info.Length, Is.EqualTo(2));

            string expectedInfo = $"Название товара: iPhone\n" +
                                $"Артикул товара: 0000\n" +
                                $"Фамилия курьера: Jobs\n" +
                                $"Номер заявки: 1\n" +
                                $"Дата и время доставки: 07.03.2025\n" +
                                $"Тип заказа: срочный\n" +
                                $"Коэффициент надбавки за срочность: 1,5\n" +
                                $"Степень срочности: в течение трех часов";

            Assert.That(info[1], Is.EqualTo(expectedInfo));
        }

        private UrgentOrder CreateTestUrgentOrder()
        {
            return new UrgentOrder("iPhone", "0000", "Jobs", "1", 1.5, UrgencyType.WithinThreeHours)
            {
                DeliveryDate = DateTime.Parse("07.03.2025"),
                Type = OrderType.Urgent
            };
        }
    }
}