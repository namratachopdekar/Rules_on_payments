using BusinessRuleEngine;
using BusinessRuleEngine.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using BusinessRuleEngine.Business;
namespace BusinessRuleEngineTest
{
    [TestClass]
    public class MembershipTest
    {
        private Mock<IItemPaymentType> _mockItemPaymentTypeFactory;
        private Mock<ICommision> _mockCommisionTypeFactory;
        private Membership _membership;
        [TestInitialize]
        public void Setup()
        {
            _mockItemPaymentTypeFactory = new Mock<IItemPaymentType>();
            _mockCommisionTypeFactory = new Mock<ICommision>();
            _membership = new Membership();
        }

        [TestMethod]
        public void Membership_ProcessOrder_Test()
        {
            Assert.AreEqual(_membership.ProcessOrder(), "Activated membership.");
        }


        [TestMethod]
        public void Membership_GenerateCommision_Test()
        {
            Assert.AreEqual(_membership.EmailNotification("email"), "Email Sent - Upgraded.");
        }
    }
}
