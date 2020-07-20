using System;
using System.Collections.Generic;
using System.Text;

namespace Kiosk_Project
{
    public abstract class Flight : Routes
    {
        public override string MenuName => "Flight";
        private readonly IScreen _screen;
        private readonly IKeyPad _keyPad;
        public Flight(IScreen screen, IKeyPad keyPad):base(screen,keyPad)
        {
            _screen = screen;
            _keyPad = keyPad;
        }
    }
}
