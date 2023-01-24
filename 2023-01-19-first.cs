using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max
{
    class Compare2
    {
        public static int Comp2(int a, int b, int c)
        {
            int min = 0;

            if (c <= a && c <= b)
            {

                min = c;
            }
            else if (a <= c && a <= b)
            {

                min = a;
            }
            else if (b <=a && b<= c)
            {

                min = b;

            }
            return min;
        }

    }
}
