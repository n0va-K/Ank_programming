using System;
using NUnit.Framework;
using OrderLibrary;

[TestFixture]
public class DeliveryTests
{
    private Delivery delivery;
    private Order[] testOrders;

    [SetUp]
    public void SetUp()
    {
        var order1 = new Order("IPhone", "0000", "Jobs", "1") { DeliveryDate = DateTime.Parse("07.03.2025") };
        var order2 = new Order("IMac", "0001", "Jobs", "2") { DeliveryDate = DateTime.Parse("07.03.2025") };
        var order3 = new Order("Charger", "0002", "Cook", "3") { DeliveryDate = DateTime.Parse("08.03.2025") };
        var order4 = new Order("MacBook", "0004", "Jobs", "4") { DeliveryDate = DateTime.Parse("07.03.2025") };

        testOrders = new Order[] { order1, order2, order3, order4};
        delivery = new Delivery("Jobs", "07.03.2025", testOrders);
    }

    [Test]
    public void ConstructorTest()
    {
        Assert.That(delivery.CourierSurname, Is.EqualTo("Jobs"));
        Assert.That(delivery.DeliveryDate, Is.EqualTo(DateTime.Parse("07.03.2025")));

        foreach (var order in testOrders)
        {
            bool Contain = order.CourierSurname == "Jobs" &&
                                  order.DeliveryDate.Date == DateTime.Parse("07.03.2025").Date;

            var ordersList = delivery.ToList();
            bool isIncluded = ordersList.Contains(order);

            Assert.That(Contain ?
                       isIncluded && ordersList.IndexOf(order) == ordersList.LastIndexOf(order) :
                       !isIncluded, Is.True);
        }
    }

    [Test]
    public void CountTest()
    {
        Assert.That(delivery.Count, Is.EqualTo(3));
    }

    [Test]
    public void IEnumerableTest()
    {
        var expectedOrders = new List<Order>();
        foreach (var order in testOrders)
        {
            if (order.CourierSurname == "Jobs" &&
                order.DeliveryDate.Date == DateTime.Parse("07.03.2025").Date)
            {
                expectedOrders.Add(order);
            }
        }

        var i = 0;
        foreach (var order in delivery)
        {
            Assert.That(order, Is.SameAs(expectedOrders[i++]));
        }
    }
}