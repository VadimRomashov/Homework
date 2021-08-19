using System;

namespace homework_8
{
    class Program
    {       
            static void Main()
        {

            Console.WriteLine("Введите ширину массива: ");
            int width = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите высоту массива: ");
            int heidht = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            int[,] arr = new int[heidht, width];
            int i = 0, k = 0;
            int count = 1;
            int j;

            while (i < heidht * width)
            {
                for (j = k; j < width - k; j++)
                {
                    i++;
                    arr[k, j] = count;
                    count++;
                }

                for (j = k + 1; j < heidht - k; j++)
                {
                    i++;
                    arr[j, width - k - 1] = count;
                    count++;
                }

                for (j = width - k - 2; j >= k; j--)
                {
                    i++;
                    arr[heidht - k - 1, j] = count;
                    count++;
                }

                for (j = heidht - k - 2; j > k; j--)
                {
                    i++;
                    arr[j, k] = count;
                    count++;
                }
                k++;
            }

            for (k = 0; k < heidht; k++)
            {
                for (j = 0; j < width; j++)
                    Console.Write(" " + arr[k, j]);
                Console.WriteLine();
            }
        }


    }
}
