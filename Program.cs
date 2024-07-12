using System;

namespace SCC_math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chieu dai: ");
            int ChieuDai = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap chieu rong: ");
            int ChieuRong = Convert.ToInt32(Console.ReadLine());
            int DienTich = ChieuDai * ChieuRong;
            Console.WriteLine("Dien tich hinh chu nhat la: " + DienTich);

        }
    }
}
