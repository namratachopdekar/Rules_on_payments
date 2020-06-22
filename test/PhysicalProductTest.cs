using BusinessRuleEngine;
using BusinessRuleEngine.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using BusinessRuleEngine.Business;

namespace BusinessRuleEngineTest
{
    [TestClass]
    public class PhysicalProductTest
    {
        private Mock<IItemPaymentType> _mockItemPaymentTypeFactory;
        private Mock<ICommision> _mockCommisionTypeFactory;
        private PhysicalProduct _physicalProduct;
        [TestInitialize]
        public void Setup()
        {
            _mockItemPaymentTypeFactory = new Mock<IItemPaymentType>();
            _mockCommisionTypeFactory = new Mock<ICommision>();
            _physicalProduct = new PhysicalProduct();
        }

        [TestMethod]
        public void Book_ProcessOrder_Test()
        {
            Assert.AreEqual(_physicalProduct.ProcessOrder(), "Packing slip for shipping is generated.");
        }


        [TestMethod]
        public void Book_GenerateCommision_Test()
        {
            Assert.AreEqual(_physicalProduct.GenerateCommision("Agent"), "Commision paid to agent.");
        }
    }
}
