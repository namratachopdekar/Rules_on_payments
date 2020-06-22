using BusinessRuleEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRuleEngine.Business
{
    public class Upgrade : IItemPaymentType, INotifier
    {
        public string ProcessOrder()
        {
            return "Upgraded.";
        }
        public string EmailNotification(string notificationType)
        {
            return "Email Sent - Upgraded.";
        }
    }
}
