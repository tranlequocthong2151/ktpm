﻿using System;
using System.Collections.Generic;
using System.Text;

namespace B4_2151050438_TranLeQuocThong
{
    class Buoi2
    {
        static double Power(double x, int n)
        {
            if (n == 0)
            {
                return 1.0;
            }
            else if (n > 0)
            {
                return x * Power(x, n - 1);
            }
            else
            {
                return Power(x, n + 1) / x;
            }
        }
    }
}
