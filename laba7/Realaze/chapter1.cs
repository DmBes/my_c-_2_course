using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;


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


        public Chapter1()

        {
            string adress = @"D:\papka1"; // Установка изначального адреса по умолчанию
            DirectoryInfo dirInfo = new DirectoryInfo(adress); //чтение всех каталогов по умолчанию
            DirectoryInfo das = new DirectoryInfo(adress);
  
           
             //FileInfo fileall = new FileInfo(adress);  //чтения всех файлов по умолчанию
            UserChoice = 1;
            
            DirectoryInfo[] x = new DirectoryInfo[] { }; //инициализация массива объктов DirectoryInfo
            x = dirInfo.GetDirectories();
            FileInfo[] AllFiles = new FileInfo[] { };//чтения всех файлов по умолчанию
            FileInfo[] vse = dirInfo.GetFiles("*.*", SearchOption.AllDirectories);

            UserChoice = 1;
            while (UserChoice > 0)
            {
                menu.PrintMenu_ch1();
                SetChoice = Convert.ToInt32(Console.ReadLine());
                vse = dirInfo.GetFiles("*.*", SearchOption.AllDirectories);
                AllFiles = dirInfo.GetFiles();


                switch (SetChoice)
                {
                    case 1:   //1 – устанавливает текущий диск/каталог
                        Console.WriteLine("Set your path"); //Установка нового пути
                        adress = Console.ReadLine(); 
                        dirInfo = new DirectoryInfo(adress);
                       

                        break;
                    
                    
                    case 2: //выводит список всех каталогов в текущем (пронумерованный)

                        
                        if (dirInfo.GetDirectories() != null)  // проверка на заполненность каталогами
                        {
                            Console.Clear(); //очистка экрана

                            x = dirInfo.GetDirectories(); // получения массива обьектов DirectoryInfo
                            int chethik = 0;
                            
                            foreach (var y in x) //Перебор всех файлов
                            {
                                

                                Console.WriteLine($"[{chethik}] - название каталога \"{y}\"");
                                menu.separator();
                                chethik++;
                            }

                            
                            
                            Console.ReadKey();
                        }
                        

                         break;
                    case 3: //выводит список всех файлов в текущем каталоге (пронумерованнный)
                        Console.Clear();
                        AllFiles = dirInfo.GetFiles();//получение массива всех файлов
                        int chethik1 = 0;//для перечисления
                        
                        foreach (var y in AllFiles) //Перебор всех файлов
                        {


                            Console.WriteLine($"[{chethik1}] - название файла \"{y}\"");
                            menu.separator();
                            chethik1++;
                        }

                        Console.ReadKey();
                        break;

                    case 4:  //выводит на экран содержимое указанного файла (по номеру)
                        menu.ClearMenu();
                        Console.Write("Введите номер файла для открытия: " );
                        int f = Int32.Parse(Console.ReadLine());
                        
                        StreamReader converse = AllFiles[f].OpenText(); // Открытие стримрайдера
                        
                        string str = converse.ReadToEnd( ); // чтение всего файла  и запись в переменную стринг
                        converse.Close(); //закрытие
                        Console.WriteLine(str); // вывод на экран прочтенной  информации
                        Console.ReadKey();


                            break;
                    case 5:  //создает каталог в текущем
                        Console.Write("Введите пожалуйста имя каталога: ");
                        string name_catalog = Console.ReadLine();
                        while (string.IsNullOrEmpty(name_catalog))//Проверка на заполнение
                        {
                            Console.Write("Введите пожалуйста Адрес каталога: ");
                            name_catalog = Console.ReadLine();
                        }

                        string path_my = dirInfo.FullName;
                        string full_path = path_my + "\\" + name_catalog; //Контакценация нового пути
                        DirectoryInfo new_directory = new DirectoryInfo(full_path);  //Новый путь с учетом адреса
                        new_directory.Create();  //Создает каталог
                        Console.WriteLine(full_path);


                        Console.ReadKey();

                        break;
                    case 6:  //удаляет каталог по номеру, если он пустой
                        if (x.Length < 0) //Проверка на пустоту
                        {
                            Console.WriteLine("Нет значения для удаления");
                            Console.ReadKey();
                            break;

                        } //Проверка на пустоту

                        Console.Write("Введите значение для удаления от 0 до {0}: ", x.Length);
                        chethik1 = Convert.ToInt32(Console.ReadLine());

                        x[chethik1].Delete();
                        break;

                    case 7:  //удаляет файлы с указанными номерами
                        if (AllFiles.Length < 0) //Проверка на пустоту
                        {
                            Console.WriteLine("Нет значения для удаления");
                            Console.ReadKey();
                            break;
                            
                        } //Проверка на пустоту

                        Console.Write("Введите значение для удаления от 0 до {0}",AllFiles.Length-1);
                        chethik1 = Convert.ToInt32(Console.ReadLine());
                        if (chethik1 >= AllFiles.Length || chethik1 < 0)
                        {
                            Console.Write("Введите значение для удаления от 0 до {0}", AllFiles.Length);
                            chethik1 = Convert.ToInt32(Console.ReadLine());
                        }//Проверка на ввод
                        AllFiles[chethik1].Delete();
                        Console.WriteLine("Удалено");
                        Console.ReadKey();
                        

                        break;
                    case 8:  //выводит список всех файлов с указанной датой создания
                             //(ищет в текущем каталоге и подкаталогах)
                             menu.ClearMenu();
                             
                             foreach (var obj in vse)
                             {
                                 Console.WriteLine($"{obj.Name} дата создания {obj.CreationTime}");
                                 menu.separator();
                             }

                             Console.ReadKey();
                        break;
                    case 9:  //выводит список всех текстовых файлов,
                             //в которых содержится указанный текст
                             //(ищет в текущем каталоге и подкаталогах)
                             Console.Clear();
                             Console.WriteLine("Введите текст для поиска");
                             String FindT = Console.ReadLine().ToString();
                             if (string.IsNullOrEmpty(FindT))
                                 {
                                Console.WriteLine("Введите текст для поиска");
                                string Find = Console.ReadLine();

                                 }
                             foreach (var obj in vse)
                             {
                                 using (StreamReader rider = obj.OpenText())  //Открытие метода для чтения
                                 {
                                     string findTXT = rider.ReadToEnd(); //чтение всего файла

                                //Regex d1 = new Regex(FindT);
                                //Console.WriteLine(d1);



                                //if (d1.IsMatch(FindT))
                                //{
                                //    Console.WriteLine("dsfs");
                                //}

                                if (findTXT.IndexOf(FindT) >= 0) // если находит индекс первого вхождения 
                                     {
                                         Console.WriteLine("Файл под именем {0} содержит значение {1}", obj.Name, findTXT);
                                        
                                     }
                                 }
                             }
                             Console.ReadKey();
                        break;
                    default:
                        break;



                    
                }

              
                
            }

        }






        //public FileInfo[] update_file(string adr)
        //{

        //}

    }
    



}
