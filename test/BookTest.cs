using BusinessRuleEngine;
using BusinessRuleEngine.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using BusinessRuleEngine.Business;

namespace BusinessRuleEngineTest
{
    [TestClass]
    public class BookTest
    {
        private Mock<IItemPaymentType> _mockItemPaymentTypeFactory;
        private Mock<ICommision> _mockCommisionTypeFactory;
        private Book _book;
        [TestInitialize]
        public void Setup()
        {
            _mockItemPaymentTypeFactory = new Mock<IItemPaymentType>();
            _mockCommisionTypeFactory = new Mock<ICommision>();
            _book = new Book();
        }

        [TestMethod]
        public void Book_ProcessOrder_Test()
        {           
            Assert.AreEqual(_book.ProcessOrder(), "Duplicate slip for Royality Department.");
        }


        [TestMethod]
        public void Book_GenerateCommision_Test()
        {
            Assert.AreEqual(_book.GenerateCommision("BookAgent"), "Commision paid to agent.");
        }
    }
}
