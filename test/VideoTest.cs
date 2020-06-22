using BusinessRuleEngine;
using BusinessRuleEngine.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using BusinessRuleEngine.Business;

namespace BusinessRuleEngineTest
{
    [TestClass]
    public class VideoTest
    {
        private Mock<IItemPaymentType> _mockItemPaymentTypeFactory;
        private Mock<ICommision> _mockCommisionTypeFactory;
        private Video _video;

        [TestInitialize]
        public void Setup()
        {
            _mockItemPaymentTypeFactory = new Mock<IItemPaymentType>();
            _mockCommisionTypeFactory = new Mock<ICommision>();
            _video = new Video();
        }

        [TestMethod]
        public void Book_ProcessOrder_Test()
        {
            Assert.AreEqual(_video.ProcessOrder(), "Added 'First Aid' video to the packing slip.");
        }

    }
}
