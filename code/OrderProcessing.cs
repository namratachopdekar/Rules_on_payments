using System;
using System.Collections.Generic;
using System.Text;
using BusinessRuleEngine.Interfaces;

namespace BusinessRuleEngine
{
    public class OrderProcessing
    {
        private readonly IPaymentTypeFactory _paymentTypeFactory;

        public OrderProcessing(IPaymentTypeFactory paymentTypeFactory)
        {
            _paymentTypeFactory = paymentTypeFactory;
        }

        public string GetOrderProcessed(OrderModel orderModel)
        {
            string response = string.Empty;
            var paymentType= _paymentTypeFactory.GetPaymentTypeInstance(orderModel.PaymentType);
            response = paymentType.ProcessOrder();
            return response;
        }

    }
}
