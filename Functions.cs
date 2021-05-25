using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Functions
    {
        public static double Moebius(ulong n)
        {
            ulong p = 0;

            // Check if divisible by two
            if (n % 2 == 0)
            {
                n = n / 2;
                p++;

                // Check if two is a repeat, then return 0
                if (n % 2 == 0)
                {
                    return 0;
                }
            }

            // Check for divisibility by other prime numbers
            for (ulong i = 3; i <= n; i = i + 2 )
            {
                //  Check if n is divisible by i
                if (n % i == 0)
                {
                    n = n / i;
                    p++;

                    // Check if i is a repeat, if so return 0
                    if (n % i == 0)
                    {
                        return 0;
                    }
                }
            }

            // Return 1 of p is even and return -1 if p is odd
            if (p % 2 == 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
            
        }
    }
}
