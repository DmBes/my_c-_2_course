using System.Collections;
using System.Collections.Generic;

namespace Laba_5
{
    public class KioslCompare: IComparer<IMagaz>
    {
        public int Compare(IMagaz x, IMagaz y)
         
        {
            if (x.Longest < y.Longest) return 1;
            else if (x.Longest > y.Longest) return -1;
            else
            {
                return 0;
            }

            

        }
    }
}