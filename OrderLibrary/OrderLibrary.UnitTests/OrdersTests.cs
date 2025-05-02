using System;
using NUnit.Framework;
using OrderLibrary;

namespace OrderLibrary.UnitTests
{
    [TestFixture]
    public class OrdersTests
    {
        [Test]
        public void CompareToTest()
        {
            var order1 = new Order("IPhone", "0000", "Jobs", "1")
            {
                DeliveryDate = DateTime.Parse("07.03.2025"),
                Type = OrderType.Urgent
            };

            var order2 = new Order("IMac", "0001", "Cook", "2")
            {
                DeliveryDate = DateTime.Parse("08.03.2025"),
                Type = OrderType.Urgent
            };

            var order3 = new Order("Charger", "0002", "Simpson", "3")
            {
                DeliveryDate = DateTime.Parse("07.03.2025"),
                Type = OrderType.Standard
            };

            var order4 = new Order("Cable", "0003", "Cook", "4")
            {
                DeliveryDate = DateTime.Parse("08.03.2025"),
                Type = OrderType.Standard
            };

            var order5 = new Order("MacBook", "0004", "Jobs", "5")
            {
                DeliveryDate = DateTime.Parse("07.03.2025"),
                Type = OrderType.Urgent
            };

            Assert.That(order1.CompareTo(order2), Is.GreaterThan(0));
            Assert.That(order2.CompareTo(order3), Is.LessThan(0));

            Assert.That(order3.CompareTo(order4), Is.GreaterThan(0));
            Assert.That(order5.CompareTo(order5), Is.EqualTo(0));
        }
    }
}
