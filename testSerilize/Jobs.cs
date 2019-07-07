using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testSerilize
{
    class Jobs<T> where T :  class, IComparable

    {
    public List<T> test;
        public int per { get; set; }
        
    public Jobs (List<T> x)
    {
        test = x;
        foreach (var my in test)
        {
            if (my is derived_class)
            {
                (my as derived_class).Print();
                break;
            }
            (my as base_class).Print();
        }

        if (T is  derived_class)
        {
            
        }

    }
    

    public Jobs ()
    {}
    }
}
