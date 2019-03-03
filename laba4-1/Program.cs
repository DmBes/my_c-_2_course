using System;
using System.Collections.Generic;


namespace laba4
{
    class Program
    {
        static void Main(string[] args)
        {
            TradeCentr korona = new TradeCentr(3000,300,100);
            korona.Print();
            System.Console.ReadKey();
            Market evroopt = new Market(100,50,20, 2);
            evroopt.Print();
            System.Console.ReadKey();

        }
    }
}
