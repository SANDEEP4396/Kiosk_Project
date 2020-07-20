using System;
using System.Collections.Generic;
using System.Text;

namespace Kiosk_Project
{
    class CheckAccount : Payment
    {
        public int AccountNumber { get; }
        public int RoutingNumber { get; }

        private readonly IScreen _screen;
        private readonly IKeyPad _keyPad;
        public decimal _amount = Amount;
        public override string PaymentType => "Check Account";
        private static readonly List<CheckAccount> Check_Accounts = new List<CheckAccount>() {
            new CheckAccount(123456, 123456789),

          };
        public CheckAccount(int accountNumber, int routingNumber)
        {
            AccountNumber = accountNumber;
            RoutingNumber = routingNumber;
        }
        public static CheckAccount Fetch_CheckDetails(long accountNumber, long routingNumber)
        {
            foreach (CheckAccount details in Check_Accounts)
            {
                if (! (accountNumber == details.AccountNumber && routingNumber == details.RoutingNumber))
                {
                    throw new ArgumentException("The entered Account or Routing Details is not valid. Please try again");  //I'm not specifying which detail is wrong just to maintain data privacy.
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
            CheckAccount _details = Fetch_CheckDetails(AccountNumber, RoutingNumber);
            if (_details != null)
            {
                if (totalAmount > _amount)
                {
                    throw new ArgumentException($"The total amount{totalAmount} is more the the account balance");
                }
                _amount -= totalAmount;
            }
            return true;
        }
    }
}

