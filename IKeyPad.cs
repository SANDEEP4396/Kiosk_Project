using System;
using System.Collections.Generic;
using System.Text;

namespace Kiosk_Project
{
  public interface IKeyPad
    {
        long ReadLine();
        long Read(int numberOfDigits);
    }
}
