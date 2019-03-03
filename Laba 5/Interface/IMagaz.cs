using System;
using System.Collections.Generic;
using System.Dynamic;


namespace Laba_5
{
    public interface IMagaz
    {
        string NameObject { get; set; }
        string AdressObject { get; set; }
        int Longest { get; set; }
        int Windth { get; set; }
        int Area(int l, int w);

        void Print();

    }
}
