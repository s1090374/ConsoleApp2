using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius;
            Console.Write("請輸入圓的半徑： ");

            if (double.TryParse(Console.ReadLine(), out radius))
            {
                double surfaceArea = Math.PI * Math.Pow(radius, 2);
                Console.WriteLine("圓的面積是： " + surfaceArea);
            }
            else
            {
                Console.WriteLine("無效的輸入。請輸入一個有效的數字。");
            }
        }
    }
}