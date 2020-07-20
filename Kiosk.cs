using System;
using System.Collections.Generic;
using System.Text;

namespace Kiosk_Project
{
    public class Kiosk
    {
        private readonly IScreen _screen;
        private readonly IKeyPad _keyPad;
        
        public decimal totalamount = 0;
        public int direction=0;
        private List<Routes> _routes = new List<Routes>();
        public Kiosk(IScreen screen, IKeyPad keyPad)
        {
            _screen = screen;
            _keyPad = keyPad;
        }

        public void Main()
        {
            try
            {
                _screen.WriteLine("Hello!! Welcome to Hawaiian Kiosk. This application helps you book the mode of travel \n which you would prefer to travel between the Hawaian Islands \n");
                _screen.WriteLine("\nSo let's select the best mode of travel and route for you!! \n");
                Routes[] routes = new Routes[]
                {
                new Ferry1(_screen,_keyPad),
                new Ferry2(_screen,_keyPad),
                new Flight1(_screen, _keyPad),
                new Flight2(_screen, _keyPad),
                new Flight3(_screen, _keyPad)
                };
                _screen.WriteLine("     1 - Ferry goes from Maui to Lanai or vice versa for $30.00 (Adult) $20.00 (Child)");
                _screen.WriteLine("     2 - Ferry goes from Maui to Lanai or vice versa for $40.00 (Adult) $20.00 (Child)");
                _screen.WriteLine("     3 - Flight goes from Honolulu to Maui or vice versa for $80.00");
                _screen.WriteLine("     4 - Flight goes from Honolulu to Maui or vice versa for $100.00");
                _screen.WriteLine("     5 - Flight goes from Honolulu to Maui or vice versa for 50.00");
                _screen.WriteLine("     0 - Exit\n");
                int choice = (int)_keyPad.ReadLine();
                switch (choice)
                {
                    case 1:
                        _screen.WriteLine($"Enter 1 if you want to travel from {routes[0].From} To {routes[0].To}. Else if you want to travel from {routes[0].To} to {routes[0].From} press other number");
                         direction = (int)_keyPad.ReadLine();                      
                        routes[0].RouetSelection();
                        if (direction != 1)
                        {
                            _screen.WriteLine($"Route Summary- {routes[0].MenuName} from {routes[0].To} to {routes[0].From} -> Cost for {routes[0].numberofPassengers} is {routes[0].numberofPassengers} X ${routes[0].Price} = ${routes[0].TotalPrice}");
                        }
                        else
                        {
                            _screen.WriteLine(routes[0].ToString());
                        }
                        totalamount = routes[0].TotalPrice;
                        SelectPaymentMethod(totalamount);
                        break;
                    case 2:
                        _screen.WriteLine($"Enter 1 if you want to travel from {routes[1].From} To {routes[1].To}. Else if you want to travel from {routes[1].To} to {routes[1].From} press other number");
                        direction = (int)_keyPad.ReadLine();
                        routes[1].RouetSelection();
                        if (direction != 1)
                        {
                            _screen.WriteLine($"Route Summary- {routes[1].MenuName} from {routes[1].To} to {routes[1].From} -> Cost for {routes[1].numberofPassengers} is {routes[1].numberofPassengers} X ${routes[1].Price} = ${routes[1].TotalPrice}");
                        }
                        else
                        {
                            _screen.WriteLine(routes[1].ToString());
                        }
                        totalamount = routes[1].TotalPrice;
                        SelectPaymentMethod(totalamount);
                        break;
                    case 3:
                        _screen.WriteLine($"Enter 1 if you want to travel from {routes[2].From} To {routes[2].To}. Else if you want to travel from {routes[2].To} to {routes[2].From} press other number");
                        direction = (int)_keyPad.ReadLine();
                        routes[2].RouetSelection();
                        if (direction != 1)
                        {
                            _screen.WriteLine($"Route Summary- {routes[2].MenuName} from {routes[2].To} to {routes[2].From} -> Cost for {routes[2].numberofPassengers} is {routes[2].numberofPassengers} X ${routes[2].Price} = ${routes[2].TotalPrice}");
                        }
                        else
                        {
                            _screen.WriteLine(routes[2].ToString());
                        }
                        totalamount = routes[2].TotalPrice;
                        SelectPaymentMethod(totalamount);
                        break;
                    case 4:
                        _screen.WriteLine($"Enter 1 if you want to travel from {routes[3].From} To {routes[3].To}. Else if you want to travel from {routes[3].To} to {routes[3].From} press other number");
                        direction = (int)_keyPad.ReadLine();
                        routes[3].RouetSelection();
                        if (direction != 1)
                        {
                            _screen.WriteLine($"Route Summary- {routes[3].MenuName} from {routes[3].To} to {routes[3].From} -> Cost for {routes[3].numberofPassengers} is {routes[3].numberofPassengers} X ${routes[3].Price} = ${routes[3].TotalPrice}");
                        }
                        else
                        {
                            _screen.WriteLine(routes[3].ToString());
                        }
                        totalamount = routes[3].TotalPrice;
                        SelectPaymentMethod(totalamount);
                        break;
                    case 5:
                        _screen.WriteLine($"Enter 1 if you want to travel from {routes[4].From} To {routes[4].To}. Else if you want to travel from {routes[4].To} to {routes[4].From} press other number");
                        direction = (int)_keyPad.ReadLine();
                        routes[4].RouetSelection();
                        if (direction != 1)
                        {
                            _screen.WriteLine($"Route Summary- {routes[4].MenuName} from {routes[4].To} to {routes[4].From} -> Cost for {routes[4].numberofPassengers} is {routes[4].numberofPassengers} X ${routes[4].Price} = ${routes[4].TotalPrice}");
                        }
                        else
                        {
                            _screen.WriteLine(routes[4].ToString());
                        }
                        totalamount = routes[4].TotalPrice;
                        SelectPaymentMethod(totalamount);
                        break;
                    case 0:
                        break;

                }
            }
            catch (Exception ex)
            {
                _screen.WriteLine(ex.ToString());
            }

        }

        public void SelectPaymentMethod(decimal totalamount)
        {
            
            bool result=false;
            
            try
            {
                _screen.WriteLine($"Enter 1 if you want to continue with the payment. Or you will Continue with the new routes.");
                int _Choice = (int)_keyPad.ReadLine();
                if (_Choice != 1)
                {
                    Main();
                }
                else
                {
                    _screen.WriteLine($"Select the below payment options \n 1. Check \n 2. Credit Card ");
                    int payment_Choice = (int)_keyPad.ReadLine();
                    
                    switch (payment_Choice)
                    {
                        case 1:
                            _screen.WriteLine("\nPlease enter the account number:");
                            int accountNumber= (int)_keyPad.Read(6);
                            _screen.WriteLine("\nPlease enter the routing number");
                           int routingNumber = (int)_keyPad.Read(9);
                            Payment[] Check_Payments = new Payment[]
                            {
                                 new CheckAccount(accountNumber,routingNumber) 
                            };

                            result = Check_Payments[0].ProcessPayment(totalamount);
                            if (result)
                            {
                                _screen.WriteLine($"\n***************Congrats you have successfully booked your trip tickets.***************\n");
                            }
                            break;
                        case 2:
                            _screen.WriteLine("\nPlease enter the card number: ");
                            long cardNumber = _keyPad.Read(16);
                            _screen.WriteLine("\nPlease enter the expiration date:");
                            int expirationDate = (int)_keyPad.Read(4);
                            _screen.WriteLine("\nPlease enter the cvv:");
                            int cvv = (int)_keyPad.Read(3);
                            Payment[] Credit_Payments = new Payment[]
                            {
                                 new CreditCard(cardNumber,expirationDate,cvv)
                            };
                            result = Credit_Payments[0].ProcessPayment(totalamount);
                            if (result)
                            {
                                _screen.WriteLine($"\n***************Congrats you have successfully booked your trip tickets***************\n");
                            }
                            break;
                    }
                    if (result == false)
                    {
                        throw new ArgumentException("\nPayment Failed");
                    }
                }
            }catch(Exception ex)
            {
                _screen.WriteLine(ex.ToString());
            }
        }
    }
}
