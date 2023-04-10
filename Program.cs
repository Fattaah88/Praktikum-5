using System;

namespace Praktikum5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan jumlah angka yang ingin diinputkan:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Masukkan nilai ke-" + (i + 1) + ":");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            int max = array[0];
            int min = array[0];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }

                if (array[i] < min)
                {
                    min = array[i];
                }

                sum += array[i];
            }

            double average = (double)sum / n;

            Console.WriteLine("Nilai tertinggi : " + max);
            Console.WriteLine("Nilai terendah : " + min);
            Console.WriteLine("Rata-rata : " + average);
        }
    }
}
