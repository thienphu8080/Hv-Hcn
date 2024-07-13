using System.Numerics;

public class Square
{
    public double Side { get; set; }

    // Phương thức tính chu vi
    public double CalculatePerimeter()
    {
        return 4 * Side;
    }

  
}

﻿namespace Code
{
     internal class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Tinh dien tich hinh chu nhat");
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

            Square square = new Square();
            square.Side = 5; // Gán độ dài cạnh của hình vuông
            double perimeter = square.CalculatePerimeter();
            Console.WriteLine("Chu vi của hình vuông là: " + perimeter);
        }
    }
}
