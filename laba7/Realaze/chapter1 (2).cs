using System;
using System.IO;



namespace laba7
{
    class Chapter1
    {
        IntMenu menu = new IntMenu(); // Инициализация пользовательского меню
       // public DirectoryInfo dirInfo = new DirectoryInfo(".");
        private int UserChoice { get; set; }  // Переменная с пользовательским значением

        // Geter i Seter + Проверка на ввод пользовательского значения
        public int SetChoice
        {
            get => UserChoice;
            set {
                while (value < 0 || value > 9)
                {
                    Console.Write("Введите корректиное значение от 0 до 9 ");
                    value = Convert.ToInt32(Console.ReadLine());
                }

                UserChoice = value;


            }
        }

        public FileInfo[] AllFiles;



        public Chapter1()

        {
            string adress = @"D:\";
            DirectoryInfo dirInfo = new DirectoryInfo(adress);
            string[] info;
            FileInfo fileall = new FileInfo(adress);
            UserChoice = 1;
            while (UserChoice > 0)
            {
                menu.PrintMenu_ch1();

                


                SetChoice = Convert.ToInt32(Console.ReadLine());
                DirectoryInfo[] x;
                switch (SetChoice)
                {
                    case 1:   //1 – устанавливает текущий диск/каталог
                        Console.WriteLine("Set your path");
                        adress = Console.ReadLine();
                        dirInfo = new DirectoryInfo(adress);
                       

                        break;
                    
                    
                    case 2: //выводит список всех каталогов в текущем (пронумерованный)

                        
                        if (dirInfo.GetDirectories() != null)
                        {
                            Console.Clear();

                            x = dirInfo.GetDirectories();
                            int chethik = 1;
                            
                            foreach (var y in x) //Перебор всех файлов
                            {
                                

                                Console.WriteLine($"[{chethik}] - название каталога \"{y}\"");
                                chethik++;
                            }

                            Console.WriteLine(x[1]);
                            
                            Console.ReadKey();
                        }
                        

                         break;
                    case 3: //выводит список всех файлов в текущем каталоге (пронумерованнный)
                        Console.Clear();
                        FileInfo[] AllFiles = dirInfo.GetFiles();
                        int chethik1 = 1;
                        ;
                        foreach (var y in AllFiles) //Перебор всех файлов
                        {


                            Console.WriteLine($"[{chethik1}] - название файла \"{y}\"");
                            chethik1++;
                        }


                        Console.ReadKey();
                        break;

                    case 4:  //выводит на экран содержимое указанного файла (по номеру)
                        Console.Write("Введите номер файла для открытия: " );
                        int f = Int32.Parse(Console.ReadLine());
                        //using (StreamReader read = new StreamReader(
                        //{

                        //}


                        break;
                    case 5:  //создает каталог в текущем

                        break;
                    case 6:  //удаляет каталог по номеру, если он пустой

                        break;

                    case 7:  //удаляет файлы с указанными номерами

                        break;
                    case 8:  //выводит список всех файлов с указанной датой создания
                             //(ищет в текущем каталоге и подкаталогах)

                        break;
                    case 9:  //выводит список всех текстовых файлов,
                             //в которых содержится указанный текст
                             //(ищет в текущем каталоге и подкаталогах)


                        break;
                    default:

                        break;


                }



            }
            


        }





        
 

    }




}
