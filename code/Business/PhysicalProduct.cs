using BusinessRuleEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRuleEngine.Business
{
    public class PhysicalProduct : IItemPaymentType, ICommision
    {
        public string ProcessOrder()
        {
            return "Packing slip for shipping is generated.";
        }
        public string GenerateCommision(string CommisionType)
        {
            return "Commision paid to agent.";
        }
    }
}
