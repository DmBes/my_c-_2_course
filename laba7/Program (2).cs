using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using laba7.Other;

namespace laba7
{
    class Program
    {
        static void Main(string[] args)
        {
            Chapter1 ChapterOne = new Chapter1();
            Trade_center tradeCenter = new Trade_center("sosedi", "marksa", 500);
            chapter2 chapterSecond = new chapter2(tradeCenter);
            //chapter3 chapterTherd = new chapter3();
           
            
            




        }
    }
}
