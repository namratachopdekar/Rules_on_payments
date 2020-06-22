using BusinessRuleEngine;
using BusinessRuleEngine.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using BusinessRuleEngine.Business;

namespace BusinessRuleEngineTest
{
    public class UpgradeTest
    {
        private Mock<IItemPaymentType> _mockItemPaymentTypeFactory;
        private Mock<ICommision> _mockCommisionTypeFactory;
        private Upgrade upgrade;
        [TestInitialize]
        public void Setup()
        {
            _mockItemPaymentTypeFactory = new Mock<IItemPaymentType>();
            _mockCommisionTypeFactory = new Mock<ICommision>();
            upgrade = new Upgrade();
        }

        [TestMethod]
        public void Membership_ProcessOrder_Test()
        {
            Assert.AreEqual(upgrade.ProcessOrder(), "Upgraded.");
        }


        [TestMethod]
        public void Membership_GenerateCommision_Test()
        {
            Assert.AreEqual(upgrade.EmailNotification("email"), "Email Sent - Upgraded.");
        }
    }
}
