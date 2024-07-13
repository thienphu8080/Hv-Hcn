using System;

namespace HinhChuNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            double len, wid;
            Console.Write("Chieu dai: ");
            len = Convert.ToDouble(Console.ReadLine());
            Console.Write("Chieu rong: ");
            wid = Convert.ToDouble(Console.ReadLine());
            Console.Write("Chu vi hinh chu nhat: {0}", (len + wid) * 2);
            Console.ReadKey();
        }
    }
}