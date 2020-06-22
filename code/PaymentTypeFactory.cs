using System;
using System.Collections.Generic;
using System.Text;
using BusinessRuleEngine.Interfaces;
using System;
using System.Linq;
using System.Configuration;
using BusinessRuleEngine.Business;

namespace BusinessRuleEngine
{
    public class PaymentTypeFactory : IPaymentTypeFactory
    {
        private readonly IItemPaymentType _physicalProduct;
        private readonly IItemPaymentType _book;
        private readonly IItemPaymentType _membership;
        private readonly IItemPaymentType _upgrade;
        private readonly IItemPaymentType _video;

        public PaymentTypeFactory(IItemPaymentType physicalProduct, IItemPaymentType book, IItemPaymentType membership,
            IItemPaymentType upgrade, IItemPaymentType video)
        {
            _physicalProduct = physicalProduct;
            _book = book;
            _membership = membership;
            _upgrade = upgrade;
            _video = video;
        }

        IItemPaymentType IPaymentTypeFactory.GetPaymentTypeInstance(Type.ProductType productType)
        {
            switch (productType)
            {
                case Type.ProductType.PhysicalProduct:
                    return _physicalProduct;

                case Type.ProductType.Book:
                    return _book;

                case Type.ProductType.Membership:
                    return _membership;

                case Type.ProductType.Upgrade:
                    return _upgrade;

                case Type.ProductType.Video:
                    return _video;

                default:
                    return _membership;

            }
          


        }
    }
}
