using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace laba7.Other
{
    class Trade_center: Kiosk
    {
        protected int CountsWorker { get; set; }



        public Trade_center(string Name, string Adress, int workers) : base(Name, Adress)
        {
            CountsWorker = workers;
        }

        public Trade_center(int workers) : base()
        {
            CountsWorker = workers;
        }


        //ToDo почему нельзя так создать
        //public Trade_center(Kiosk a, int workers) :base()
        //{

        //}

}

    
}
