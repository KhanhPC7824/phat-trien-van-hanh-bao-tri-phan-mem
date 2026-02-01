using NUnit.Framework;
using ClothesWebNET.Services;
using ClothesWebNET.Models;
using System.Collections.Generic;

namespace ClothesWebNET.Tests
{
    [TestFixture]
    public class CartServiceTests
    {
        private CartService _cartService;

        [SetUp]
        public void Setup()
        {
            _cartService = new CartService();
        }

        [Test]
        public void CalculateTotal_EmptyCart_ReturnsZero()
        {
            // Arrange
            var cart = new Cart();

            // Act
            var result = _cartService.CalculateTotal(cart);

            // Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void CalculateTotal_WithItems_ReturnsCorrectSum()
        {
            // Arrange
            var cart = new Cart();
            var product1 = new Product { idProduct = "1", price = 100 };
            var product2 = new Product { idProduct = "2", price = 200 };

            cart.AddCart(product1, "M", 2); // 100 * 2 = 200
            cart.AddCart(product2, "L", 1); // 200 * 1 = 200

            // Act
            var result = _cartService.CalculateTotal(cart);

            // Assert
            Assert.AreEqual(400, result);
        }
    }
}
