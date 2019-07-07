using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace testequelse
{
    class one
    {
        public string Fname;
        public string Lname;


        public one(string a, string b)
        {
            Fname = a;
            Lname = b;
        }
        public one() : this ("Iva", "serebryakov") { }


        public override bool Equals(object obj)
        {
            //if (obj.GetType() != this.GetType()) return false;
            if (obj is string) return ((string)obj).ToLower() == this.Fname.ToLower();
            if (obj is one) return ((one) obj).Fname.ToLower() == this.Fname.ToLower();
            return false;
        }
    }
}

