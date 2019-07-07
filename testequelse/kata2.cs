using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testequelse
{

    class AreTheySame
    {
        public static bool comp(int[] a, int[] b)
        {
            if (a == null || b == null) return false;
            if (a.Length != b.Length) return false;
            
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == null || b[i] == null) return false;
                a[i] *= a[i];

            }

            if (a.Sum() != b.Sum()) return false;
           
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (j == b.Length)
                    {
                        if (a[i] != b[j])
                        {
                            return false;
                        }
                    }

                    if (a[i] == b[j])
                    {
                        break;
                    }
                    continue;
                }
                
            }


            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (j == b.Length)
                    {
                        if (b[i] != a[j])
                        {
                            return false;
                        }
                    }

                    if (b[i] == a[j])
                    {
                        break;
                    }
                    continue;
                }

            }




            
            return true;
        }



    }
}
