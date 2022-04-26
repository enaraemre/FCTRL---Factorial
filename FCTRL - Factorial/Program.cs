using System;
using System.Collections.Generic;
namespace FCTRL___Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Int32> numbers = new List<Int32>();
            int sonuc1 = 1, sonuc = 0, bol = 5;
            for (int i = 0; i < n; i++)
                numbers.Add(int.Parse(Console.In.ReadLine()));

            for(int i=0; i<n; i++)
            {
                while (sonuc1 != 0)
                {   
                    sonuc = sonuc + numbers[i] / bol;
                    sonuc1 = numbers[i] / bol;
                    bol *=5;
                }
                sonuc1 = 1;
                bol = 5;
                Console.WriteLine(sonuc);
                sonuc = 0;
            }
        }
    }
}
