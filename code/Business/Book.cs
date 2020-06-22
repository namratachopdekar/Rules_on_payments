using BusinessRuleEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRuleEngine.Business
{
    public class Book : IItemPaymentType, ICommision
    {
        //public Book(IItemPaymentType itemPaymentType,ICommision commision)
        //{

        //}
        public string ProcessOrder()
        {
            return "Duplicate slip for Royality Department.";
        }

        public string GenerateCommision(string CommisionType)
        {
            return "Commision paid to agent.";
        }
    }
}
