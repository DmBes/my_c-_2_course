using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testdelegate
{
    public delegate int Transformer(int x);

    class Util
    {
        public static void Transform(int[] values, Transformer t)
        {
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = t(values[i]);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            int[] values = {1, 2, 3};
            Util.Transform(values, Square);
            foreach (var  i  in values)
            {
                Console.Write(i + " ");
            }
            Console.Clear();
        

            Stock stocj = new Stock("THPW");
            stocj.Price = 27.10M;
            stocj.PriceChanched += Stocj_PriceChanched;

            stocj.Price = 500;


        }

        private static void Stocj_PriceChanched(object sender, PriceChanchedEventArgs e)
        {
            if ((e.NewPrice - e.LastPrice) / e.LastPrice > 0.1M)
            {
                Console.WriteLine("Alert, 10% stock increase");
            }
        }

        static int Square(int x) => x * x;


    }
}
