using System;
using System.Collections.Generic;
using System.Text;

namespace Kiosk_Project
{
   public class KioskScreen :IScreen
    {
        public void Write(string message)
        {
            Console.Write(message);
        }

        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
