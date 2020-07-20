using System;
using System.Collections.Generic;
using System.Text;

namespace Kiosk_Project
{
   public class CreditCard : Payment
    {
        public long CardNumber { get; }
        public long ExpirationDate { get; }
        public long CVV { get; }
        public decimal _amount =Amount;
 
        public override string PaymentType => "Credit Card";

        private static readonly List<CreditCard> Credit_Details = new List<CreditCard>() {
            new CreditCard(1234567891234567, 1821,400),

          };
        public CreditCard(long cardNumber,int expirationDate, int cvv)
        {
            CardNumber = cardNumber;
            ExpirationDate = expirationDate;
            CVV = cvv;
        }
        public static CreditCard Fetch_CardDetails(long cardNumber, long expirationDate, long cvv)
        {
            foreach (CreditCard details in Credit_Details)
            {
                if (!(cardNumber == details.CardNumber && expirationDate==details.ExpirationDate&& cvv==details.CVV))
                {
                    throw new ArgumentException("The entered Card Details are not valid. Please try again"); //I'm not specifying which detail is wrong just to maintain data privacy.
                }
                else
                {
                    return details;
                }
            }           
            return null;
        }

        public override bool ProcessPayment(decimal totalAmount)
        {
            CreditCard _details = Fetch_CardDetails(CardNumber,ExpirationDate,CVV);
            if (_details != null)
            {
                if (totalAmount > _amount || _amount < 0)
                {
                    throw new ArgumentException($"The total amount{totalAmount} is more the the account balance");
                }

                _amount -=totalAmount ;
            }
            return true;
        }
    }
}
