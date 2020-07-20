using System;
using System.Collections.Generic;
using System.Text;

namespace Kiosk_Project
{
    public abstract class Ferry : Routes
    {
        private readonly IScreen _screen;
        private readonly IKeyPad _keyPad;
        public override string MenuName => "Ferry";
        public abstract bool IsChild { get; }

        public Ferry(IScreen screen,IKeyPad keyPad):base(screen,keyPad)
        {
            _screen = screen;
            _keyPad = keyPad;
        }
        public override string ToString()
        {
            if (IsChild)
            {
                return base.ToString() + $"(Child)";
            }            
                return base.ToString() + $"(Adult)";
        }
        

    }
}
