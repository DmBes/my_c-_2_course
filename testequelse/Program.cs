using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testequelse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] re = new [] {3, 1, 1, 4};

            int[] pwx = new[] {9, 0, 2, 16};
            AreTheySame.comp(re,pwx);

            Kata.CountPositivesSumNegatives(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15});

            one Ivan = new one("4", "petr");
            one Sergey = new one("Sergey", "Sergey");
            one Dima = new one("Dima", "Biaspalau");
            one Sasha = new one("Sasha", "Bia");

            List<one> people = new List<one>(){Ivan,Sergey,Dima,Sasha};
            string di = "dima";
            bool xa = Dima.Equals(di);
            Ivan.Equals(di);
            two qw = new two(3,4);
            two q1 = new two(4,5);
            two q2 = new two(5,6);
            two q5 = new two(3,7);
            int wq = 4;
            bool g = q1.Equals(wq);
            bool fd= q1.Equals(Ivan);
            LinkedList<string> sda = new LinkedList<string>();
            sda.AddFirst(Ivan.Fname);
            sda.AddFirst(Sergey.Fname);



        }
    }
}
