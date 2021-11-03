using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 1, 3, 5, 7, 9, 11, 13, 17, 19, 21 };

            int eksik = 0;

            for (int i = 0; i < dizi.Length - 1; i++)
            {

                if (dizi[i + 1] - dizi[i] != 2)
                {
                    eksik = (dizi[i] + dizi[i + 1]) / 2;
                }

            }
            Console.WriteLine(eksik);
        }
    }
}
