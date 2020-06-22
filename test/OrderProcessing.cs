using BusinessRuleEngine;
using BusinessRuleEngine.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace BusinessRuleEngineTest
{
    [TestClass]
    public class OrderProcessingTest
    {
        private Mock<IPaymentTypeFactory> _mockPaymentTypeFactory;
        private Mock<IItemPaymentType> _mockItemPaymentTypeFactory;

        [TestInitialize]
        public void Setup()
        {
            _mockPaymentTypeFactory = new Mock<IPaymentTypeFactory>();
            _mockItemPaymentTypeFactory = new Mock<IItemPaymentType>();

        }
        [TestMethod]
        public void GetOrderProcessed_Test()
        {
            _mockPaymentTypeFactory.Setup(s => s.GetPaymentTypeInstance(It.IsAny <Type.ProductType>())).Returns(_mockItemPaymentTypeFactory.Object);
            OrderModel orderModel = new OrderModel
            {
                PaymentType = Type.ProductType.Book
            };
            _mockItemPaymentTypeFactory.Setup(s => s.ProcessOrder()).Returns("Tested");
        }
    }
}
