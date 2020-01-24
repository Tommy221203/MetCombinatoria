using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public class CalcoliCombinatori
    {
        public static long Fattoriale(long n)
        {
            if (n == 1||n==0)
            {
                return 1;
            }
            else
            {
                return n * Fattoriale(n - 1);
            }

        }
    }
}
