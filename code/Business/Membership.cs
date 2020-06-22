using BusinessRuleEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRuleEngine.Business
{
    public class Membership : IItemPaymentType, INotifier
    {
        public string ProcessOrder()
        {
            return "Activated membership.";
        }
        public string EmailNotification(string notificationType)
        {
            return "Email Sent - Upgraded.";
        }

    }
}
