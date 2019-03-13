using System.Collections;
using System.Collections.Generic;

namespace Laba_5
{
    public class CompareTwo : IComparer<IMagaz>  // Сортировка
    {
        public int Compare(IMagaz x, IMagaz y)

        {
            if (x.NameObject.Length < y.NameObject.Length) return 1;
            else if (x.NameObject.Length > y.NameObject.Length) return -1;
            else
            {
                return 0;
            }



        }
    }
}