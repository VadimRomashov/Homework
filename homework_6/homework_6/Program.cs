using System;
using System.Diagnostics;
using System.Text;

namespace homework_6
{
    class Program
    {

        public static Process[] process { get; set; }
        

        static void Main(string[] args)
        {
            Console.WriteLine("Задание №1");
            ShowMenu();
            Console.WriteLine("\nЗадание №2");
            CreateArr();
         }

        static (int numberProcess, string nameProcess)[] CreateProceesList()
        {
            process = Process.GetProcesses();
            (int numberProcess, string nameProcess)[] processList = new (int numberProcess, string nameProcess)[process.Length];

            for (int i = 0; i < process.Length; i++)
            {
                //int numberProcess = i + 1;
                //string nameProcess = Convert.ToString(process[i]);
                //Console.WriteLine($"{numberProcess}: {nameProcess}");
                Console.Write(process[i].Id) ;
                Console.WriteLine(" " + process[i].ProcessName);
            }

            Console.WriteLine("");
            ShowMenu();
            return processList;
        }

        static void KillingProccesName()
        {
            Console.WriteLine("Введите имя процесса");            
            Process[] process = Process.GetProcessesByName(Console.ReadLine());
            for (int i = 0; i < process.Length; i++)
            {
                process[i].Kill();
            }
            Console.WriteLine("");
            ShowMenu();
        }

        static void KillingProccesID()
        {
            Console.WriteLine("Введите ID процесса");
            int killID = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < process.Length; i++)
            {
                if (process[i].Id == killID)
                {
                    process[i].Kill();
                }                
            }
            Console.WriteLine("");
            ShowMenu();
        }

        static void ShowMenu()
        {
            Console.WriteLine("1 - Отобразить список процессов\n2 - Грохнуть процесс по имени\n3 - Грохнуть процесс по ID\n\n5 - Следующее задание");
            int choice = Convert.ToInt32(Console.ReadLine());
            
                switch (choice)
                {
                    case 1:
                        CreateProceesList(); // отобразить еще раз список процессов
                         break;
                    case 2:
                        KillingProccesName();   //     грохнуть процесс по имени
                         break;
                     case 3:
                         KillingProccesID();     //     грохнуть процесс по имени
                         break;
                    case 5:                     // в начало программы 
                         return;

                default:
                        Console.WriteLine("Введен неправильный номер. Выберете из перечисленных:");
                        ShowMenu();
                        break;
                }
        }

        static void CreateArr()
        {
            int sum = 0;
            Random random = new Random();
            string[,] sArray = new string[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sArray[i, j] = random.Next(1, 9).ToString();
                    Console.Write(sArray[i, j]+" ");
                }
                Console.WriteLine("");
            }



            //sArray[2, 3] = "sdf";

            try
            {
                sum = sumArray(sArray);
            }
            catch (MyArraySizeExeption e)
            {
               Console.WriteLine(e.StackTrace);
            }
            catch (MyArrayDataException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            Console.WriteLine(sum);
        }

        public static int sumArray(string[,] sArray)
        {
            int sum = 0;
            if (sArray.GetLength(0) != 4) throw new MyArraySizeExeption();
            for (int i = 0; i < sArray.GetLength(0); i++)
            {
                for (int j = 0; j < sArray.GetLength(1); j++)
                {
                    try
                    {
                        sum += Int32.Parse(sArray[i, j]);
                    }
                    catch (Exception e)
                    {
                        throw new MyArrayDataException(i, j);
                    }

                }
            }
            return sum;
        }


    }
}
