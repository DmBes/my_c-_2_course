using System;




namespace new2
{


    class Program
            {
                static void Main(string[] args)
                {


                    Man Ivan = new Man(10);
                    Ivan.move();



                    Man Ivan2 = (Man)Ivan.Clone();
                    Ivan2.move();
                    


                    Man Ivan33 = (Man)Ivan.Clone();
                    







                    Console.WriteLine(Ivan2.GetHashCode() == Ivan.GetHashCode());
                    People Serher = new Man(50);
                    Serher.move();

                    People Dima = new People(30);
                    Dima.move();


                    Imove alex = new Man(40);
                    alex.move();

                    Imove jura = new People(22);
                    jura.move();

                    //People[] kollekcion = new People[] {Dima, (People)jura};
                    //Array.Sort(kollekcion);
                    //foreach (var q in kollekcion)
                    //{
                    //    Console.WriteLine(q.nameIs);
                    //}






                    Console.ReadKey();




                }


        
        
    }
}
