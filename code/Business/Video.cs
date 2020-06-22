using BusinessRuleEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRuleEngine.Business
{
    public class Video : IItemPaymentType
    {
        public string ProcessOrder()
        {
            return "Added 'First Aid' video to the packing slip.";
        }
    }
}
