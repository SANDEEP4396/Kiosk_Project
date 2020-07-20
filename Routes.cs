using System;
using System.Collections.Generic;
using System.Text;

namespace Kiosk_Project
{
    public abstract class Routes
    {
        private readonly IScreen _screen;
        private readonly IKeyPad _keyPad;
       
        public abstract string From { get; }
        public abstract string To { get; }
        public abstract string MenuName { get; }
        public abstract int numberofPassengers {get;}

        public abstract decimal Price { get; }

        public Routes(IScreen screen, IKeyPad keyPad)
        {
            _screen = screen;
            _keyPad = keyPad;
        }
        public abstract decimal TotalPrice { get; }
        public abstract void RouetSelection();

        public override string ToString()
        {
           
            return $"Route Summary- {MenuName} from {From} to {To} -> Cost for {numberofPassengers} is {numberofPassengers} X ${Price} = ${TotalPrice}";
        }
       
    }
}
