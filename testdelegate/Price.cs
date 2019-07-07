using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testdelegate
{
    public class PriceChanchedEventArgs: EventArgs
    {
        public readonly decimal LastPrice;
        public readonly decimal NewPrice;

        public PriceChanchedEventArgs(decimal lastprice , decimal newprice)
        {
            LastPrice = lastprice;
            NewPrice = newprice;
        }
    }

    public class Stock
    {
        string symbol;
        decimal price;

        public Stock(string symbol)
        {
            this.symbol = symbol;
        }

        public event EventHandler<PriceChanchedEventArgs> PriceChanched;

        protected virtual void OnPriceChanched(PriceChanchedEventArgs e)
        {
            PriceChanched?.Invoke(this, e);
        }

        public decimal Price
        {
            get { return price; }
            set
            {
                if (price == value) return;
                decimal oldPrice = price;
                price = value;
                OnPriceChanched(new PriceChanchedEventArgs(oldPrice,price));
            }
        }
    }

}
