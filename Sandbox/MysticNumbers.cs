using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class MysticNumbers
    {
        public int ThreeNumbers(int a, int b, int c)
        {
            int result;

            if (b > a)
            {
                result = b;
                if (c > b)
                {
                    result = c;
                }
            }
            else
            {
                result = a;
                if (c > a)
                {
                    result = c;
                }
            }

            return result;
        }

        public int TwoNumbers(int a, int b)
        {
            int result;

            result = b > a ? b : a;
            return result;
        }

        public int FourNumbers(int a, int b, int c, int d)
        {
            int x = TwoNumbers(a, b);
            int y = TwoNumbers(c, d);
            int result = TwoNumbers(x, y);

            return result;
        }

        public int ThreeNumbersRewritten(int a, int b, int c)
        {
            int x = TwoNumbers(a, b);
            int result = TwoNumbers(x, c);

            return result;
        }


    }
}
