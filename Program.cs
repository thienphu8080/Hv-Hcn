using System.Numerics;
﻿namespace Code
{
    {internal class Program
        static void Main(string[] args)
        {
            Console.Write("Nhap chieu dai: ");
            int ChieuDai = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap chieu rong: ");
            int ChieuRong = Convert.ToInt32(Console.ReadLine());
            int DienTich = ChieuDai * ChieuRong;
            Console.WriteLine("Dien tich hinh chu nhat la: " + DienTich);
            Console.WriteLine("Tinh dien tich hinh vuong");
            Console.Write("Canh = ");
            BigInteger canh= int.Parse(Console.ReadLine());
            Console.WriteLine("Dien tich hinh vuong la: {0}", canh * canh);
        }
    }
}
