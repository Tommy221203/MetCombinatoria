using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public class CalcoliCombinatori
    {
        public static BigInteger Fattoriale(int n)
        {
            long fattoriale = 1;
            for(int i=n;i>1;i--)
            {
                fattoriale = fattoriale * i;
            }
            return fattoriale;
        }
    }
}
