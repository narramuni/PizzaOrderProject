using NUnit.Framework;
using SelectThePizza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary
{
    [TestFixture]
    public class PizzaOrderTests
    {
        [Test]
        public void OrderCheckout_TotalPriceCalculation()
        {
            // Arrange
            var orderCheckout = new OrderCheckoutModel();
            orderCheckout.SelectedPizza = "Pepperoni";
            orderCheckout.Quantity = 2;

            // Act
            var totalPrice = orderCheckout.TotalPrice;

            // Assert
            Assert.AreEqual(20.0, totalPrice);
        }

        [Test]
        public void OrderConfirmation_OrderIdGenerated()
        {
            // Arrange
            var orderConfirmation = new OrderConfirmationModel();

            // Act
            orderConfirmation.OnGet(123, 20.0, "Pepperoni");

            // Assert
            Assert.AreEqual(123, orderConfirmation.OrderId);
        }
    }
}
