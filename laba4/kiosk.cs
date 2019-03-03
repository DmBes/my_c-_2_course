using System;


namespace laba4
{
    class Kiosk: Market
    {
        private string Street { get; set; }


        public string GetStreet
        {
            get => GetStreet = Street;
            set => Street = value;
        }



        public Kiosk(int L, int W, int H, int F, string street ) : base(L, W, H, F)
        {
            GetStreet = street;

        }

        public sealed override int Volume(int Long, int width, int height)
        {
            return Long * Width * Height;
        }


        public new void Print()
        {
            Console.WriteLine(
                $"Это киоск.\n Длинна помещения составляет {Long}, ширина составляет {Width}, Высота {Height}, Обьем {Volume(Long, Width, Height)}\n Находится на улице {GetStreet}");
        }


    }
}
