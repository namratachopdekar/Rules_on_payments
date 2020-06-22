using System;
using System.Collections.Generic;
using System.Text;
using BusinessRuleEngine;

namespace BusinessRuleEngine.Interfaces
{
    public interface IPaymentTypeFactory
    {
        IItemPaymentType GetPaymentTypeInstance(Type.ProductType productType);
    }
}
