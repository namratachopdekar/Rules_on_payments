using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRuleEngine.Interfaces
{
    public interface INotifier
    {
        string EmailNotification(string notificationType);
    }
}
