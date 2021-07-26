using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
           // 1.Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.
            Console.WriteLine(" ЗАДАНИЕ №1 \n");

            Console.WriteLine("Введите максимальную температуру:");
            double max_temp = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите минимальную температуру:");
            double min_temp = Convert.ToDouble(Console.ReadLine());

            double average_value = (max_temp + min_temp) / 2;

            if (max_temp < min_temp)
            {
                Console.WriteLine($"\nУчитесь сравнивать числа!\nСреднесуточная температура: {average_value}");
            }
            else
            {
                Console.WriteLine($"Среднесуточная температура: {average_value}");
            }

            //2. Запросить у пользователя порядковый номер текущего месяца и вывести его название.
            Console.WriteLine("\n\n ЗАДАНИЕ №2 \n");

            Console.WriteLine("Введите порядковый номер месяца:");
            int number_month = Convert.ToInt32(Console.ReadLine());
            string month_title = "";
            switch (number_month)
            {
                case 1:
                    month_title = "Январь";
                    break;
                case 2:
                    month_title = "Ферваль";
                    break;
                case 3:
                    month_title = "Март";
                    break;
                case 4:
                    month_title = "Апрель";
                    break;
                case 5:
                    month_title = "Май";
                    break;
                case 6:
                    month_title = "Июнь";
                    break;
                case 7:
                    month_title = "Июлб";
                    break;
                case 8:
                    month_title = "Август";
                    break;
                case 9:
                    month_title = "Сентябрь";
                    break;
                case 10:
                    month_title = "Октябрь";
                    break;
                case 11:
                    month_title = "Ноябрь";
                    break;
                case 12:
                    month_title = "Декабрь";
                    break;
                default:
                    Console.WriteLine("Не бывает такого месяца!");
                    break;
            }

            string changed_month = (number_month == 1 || number_month == 2 || number_month == 12) && average_value > 0 ? $"\nВыбранный месяц - {month_title}.\nДождливая зима! (ЗАДАНИЕ №5)" : $"\nВыбранный месяц - {month_title}";
            Console.WriteLine(changed_month);

            //3.Определить, является ли введённое пользователем число чётным.
            Console.WriteLine("\n\n ЗАДАНИЕ №3 \n");
            Console.WriteLine("Введите число:");
            int number = Convert.ToInt32(Console.ReadLine());
            string even = number % 2 != 1? "Число четное" : "Число нечетное";
            Console.WriteLine(even);
   
            //4. Для полного закрепления понимания простых типов найдите любой чек, либо фотографию этого чека в интернете и схематично нарисуйте его в консоли,
            //только за место динамических, по вашему мнению, данных (это может быть дата, название магазина, сумма покупок) подставляйте переменные, которые были
            //заранее заготовлены до вывода на консоль.
            Console.WriteLine("\n\n ЗАДАНИЕ №4 \n");

            Console.WriteLine("\nПока не разобрался с битовыми масками\n");

            Console.ReadKey();

        }
    }
}
