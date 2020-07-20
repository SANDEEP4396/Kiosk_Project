using System;
using System.Collections.Generic;
using System.Text;

namespace Kiosk_Project
{
  public class KioskKeyPad : IKeyPad
    {
        public long ReadLine()
        {
            string num = Console.ReadLine();
            long input_num= long.Parse(num);
            if (input_num > 9)
            {
                throw new ArgumentException($"The entered number {input_num} is out of range. Try giving numbers from 0-9");
            }
            if (input_num < 0)
            {
                throw new ArgumentException($"The number {input_num} is a negative value. It should be a positive value");
            }
                return input_num;
        }

        public long Read(int numberOfDigits)
        {         
            long num = 0;
            long digits = 1;
            if (numberOfDigits > 18) numberOfDigits = 18;
            for (int i = 0; i < numberOfDigits - 1; i++)
            {
                digits *= 10;

            }
            while (digits > 0)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.KeyChar >= '0' && key.KeyChar <= '9')
                {
                    num = num + digits * (key.KeyChar - '0');
                    digits = digits / 10;
                }
            }
            return num;
        }
    }
}
