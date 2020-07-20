using System;
using System.Collections.Generic;
using System.Text;

namespace Kiosk_Project
{
    public class Flight3 : Flight
    {
        
        public override string From => "Oahu";
        public override string To => "Maui";

        public int totalpassengers;

        public decimal cost = 50;
        private readonly IScreen _screen;
        private readonly IKeyPad _keyPad;
        public Flight3(IScreen screen, IKeyPad keyPad) : base(screen, keyPad)
        {
            _screen = screen;
            _keyPad = keyPad;
        }
        public override void RouetSelection()
        {
            _screen.WriteLine("Enter the number of Passengers: ");
            totalpassengers = (int)_keyPad.ReadLine();
            cost *= totalpassengers;
        }

        public override int numberofPassengers => totalpassengers;
        public override decimal TotalPrice => cost * numberofPassengers;
        public override decimal Price => cost;

    }
}
