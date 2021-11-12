using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string reslut = "";
            int n, r;
            Console.WriteLine("enter the demical number:");
            n = Convert.ToInt32(Console.ReadLine());
            while(n>0)
            {
                r = n % 2;
                reslut = Convert.ToString(r) + reslut;
                n = n / 2;
            }
            Console.WriteLine("Binary number(0)", reslut);
        }
    }
}
