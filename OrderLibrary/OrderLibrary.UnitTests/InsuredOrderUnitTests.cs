using System;
using NUnit.Framework;
using OrderLibrary;

namespace OrderLibrary.UnitTests
{
    [TestFixture]
    public class InsuredOrderUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var order = CreateTestInsuredOrder();

            Assert.That(order.InsuarenceCompany, Is.EqualTo("Strahuem Bystro"));
            Assert.That(order.InsuarenceAmount, Is.EqualTo(10000));
        }
        [Test]
        public void GetInfoTest()
        {
            var order = CreateTestInsuredOrder();
            var info = order.GetInfo();

            Assert.That(info.Length, Is.EqualTo(2));

            string expectedInfo = $"Название товара: iPhone\n" +
                                $"Артикул товара: 0000\n" +
                                $"Фамилия курьера: Jobs\n" +
                                $"Номер заявки: 1\n" +
                                $"Дата и время доставки: 07.03.2025\n" +
                                $"Тип заказа: обычный\n" +
                                $"Название страховой компании: Strahuem Bystro\n" +
                                $"Сумма страховки: 10000 руб.";

            Assert.That(info[1], Is.EqualTo(expectedInfo));
        }

        private InsuredOrder CreateTestInsuredOrder()
        {
            return new InsuredOrder("iPhone", "0000", "Jobs", "1", "Strahuem Bystro", 10000)
            {
                DeliveryDate = DateTime.Parse("07.03.2025"),
                Type = OrderType.Standard
            };
        }
    }
}
