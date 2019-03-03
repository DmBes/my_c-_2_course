using System;


namespace laba2
{
    class  rational
    {
        private int _numerator, _denominator = 1;

        public int numerator_1 { get => _numerator;
            set => _numerator = value;
        }

        public int denominator_1 { get => _denominator;

            set => _denominator = value;
        }


       



        public rational(int num, int denum) {
            numerator_1 = num;
            if (denum > 0) denominator_1 = denum;
            else denominator_1 = 1;

        }

        public int this [int index]
        {
            get { if (index == 0)
                    return numerator_1;
                return denominator_1;
            
            }
            set
            {
                if (index == 0) { numerator_1 = value; }
                else { denominator_1 = value; }

            }


        }
   

        public rational(int num) : this(num, 1) { }


        public rational(double x) {
            int den = 0;

            while (x % 10 != 0)
            {
                x *= 10;
                if (den == 0) { den = 10; } else { den *= 10; };
            }
            numerator_1 = Convert.ToInt32(x);
            denominator_1 = den;
        }

        public rational() : this(0, 1) { }

        public void print()
        {
            Console.WriteLine("Числитель равен {0} и знаменатель равен {1}", numerator_1, denominator_1);
            //Console.ReadKey();
        }

        public override  string ToString()
        {
            return String.Format("Числитель = {0} Знаменатель равен {1}", numerator_1, denominator_1);

        }


        public void Norm()
        {
            int min = (Math.Abs((numerator_1)) > denominator_1 ? denominator_1 : Math.Abs(numerator_1)) ;
        while (min >= 1)
            {
                if (numerator_1 % min == 0 && denominator_1 % min == 0)
                {
                    break;
                }

                min--;
            }

        denominator_1 /= min;
        numerator_1 /= min;


        }



        private void Nod(rational one, rational two)
        {
         
        }

        public static rational operator + (rational one, rational two)
        {
            return new rational(one.numerator_1 * two.denominator_1 + two.numerator_1 * one.denominator_1,
                one.denominator_1 * two.denominator_1);
        }

        public static rational operator - (rational one, rational two)
        {
            return new rational(one.numerator_1 * two.denominator_1 - one.denominator_1 * two._numerator,
                one.denominator_1 * two.denominator_1);
        }
        public static rational operator * (rational one, rational two)
        {
            return new rational(one.numerator_1 * two.numerator_1,
                one.denominator_1 * two.denominator_1);
        }
        public static rational operator / (rational one, rational two)
        {
            return new rational(one.numerator_1 * two.denominator_1,
                one.denominator_1 * two.numerator_1);
        }
        public static rational operator ++ (rational one)
        {
            return new rational(one.numerator_1+one.denominator_1, one.denominator_1);
        }
        public static rational operator --(rational one)
        {
            return new rational(one.numerator_1 + one.denominator_1, one.denominator_1);
        }

        public static bool operator == (rational one, rational two)
        {
           bool s = one.numerator_1  * two.denominator_1 == two.numerator_1 * one.numerator_1 ?  true :  false;
           return s;

        }

        public static bool operator !=(rational one, rational two)
        {
            bool s = one.numerator_1  * two.denominator_1 == two.numerator_1 * one.numerator_1 ?  false :  true;
            return s;

        }
        
        public static bool operator > (rational one, rational two)
        {
            bool s = one.numerator_1  * two.denominator_1 > two.numerator_1 * one.numerator_1 ?  true :  false;
            return s;
            }
        public  static  bool operator < (rational one, rational two)
        {
            bool s = one.numerator_1  * two.denominator_1 < two.numerator_1 * one.numerator_1 ?  true :  false;
            return s;
        }

        public static bool operator true(rational one)
        {
            if (one.numerator_1 != 0)
                return true;
            return false;
        }

        public static bool operator false(rational one)
        {
            if (one.numerator_1 == 0)
                return true;
            return false;
        }

        //public static implicit operator rational (int enumerates)
        //{
        //    return new rational(enumerates, 1);
          
        //}

        //public static explicit operator int (rational one)
        //{
        //    return Convert.ToInt32(one.numerator_1/ one.denominator_1);
        //}

        public static implicit operator  int (rational two)
        {
            return Convert.ToInt32(two.numerator_1 / two.denominator_1);

        }

        public static explicit operator rational(int t)
        {
            return new rational(t,1);
        }


    }



}
