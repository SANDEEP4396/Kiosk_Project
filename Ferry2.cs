using System;
using System.Collections.Generic;
using System.Text;

namespace Kiosk_Project
{
    class Ferry2 : Ferry
    {
        private readonly IScreen _screen;
        private readonly IKeyPad _keyPad;
        public override string From => "Maui";
        public override string To => "Molokai";
        public int adultCost = 40;
        public int childCost = 20;

        bool passengertype = false;

        public int totalpassengers;

        public decimal cost = 0;
        public Ferry2(IScreen screen, IKeyPad keyPad) : base(screen, keyPad)
        {
            _screen = screen;
            _keyPad = keyPad;
        }
        public override void RouetSelection()
        {
            _screen.WriteLine("Enter 1 for Child; Otherwise Adult ");
            long passenger_type = _keyPad.ReadLine();
            if (passenger_type == 1)
            {
                cost = childCost;
                passengertype = true;
            }
            else
            {
                cost = adultCost;
            }
            _screen.WriteLine("Enter the number of Passengers: ");
            totalpassengers = (int)_keyPad.ReadLine();
           
        }
        public override bool IsChild => passengertype;
        public override int numberofPassengers => totalpassengers;
        public override decimal TotalPrice => Price * numberofPassengers;
        public override decimal Price => cost;

    }
}

