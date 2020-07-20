using System;
using System.Collections.Generic;
using System.Text;

namespace Kiosk_Project
{
    public abstract class Payment
    {
        public static decimal Amount = 500;
        
       public abstract bool ProcessPayment(decimal totalAmount);
       public abstract string PaymentType { get; }
    }
}
