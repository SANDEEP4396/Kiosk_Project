using System;

namespace Kiosk_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Hawaii Travels\n");

            var screen = new KioskScreen();
            var keypad = new KioskKeyPad();

            var kiosk = new Kiosk(screen, keypad);
            kiosk.Main();

        }
    }
}
