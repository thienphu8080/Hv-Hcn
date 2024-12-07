using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap chieu dai: ");
        double chieuDai = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhap chieu rong: ");
        double chieuRong = Convert.ToDouble(Console.ReadLine());

        double chuVi = TinhChuVi(chieuDai, chieuRong);
        double dienTich = TinhDienTich(chieuDai, chieuRong);

        Console.WriteLine($"Chu vi cua hinh chu nhat la: {chuVi}");
        Console.WriteLine($"Dien tich cua hinh chu nhat la: {dienTich}");
    }

    static double TinhChuVi(double dai, double rong)
    {
        return 2 * (dai + rong);
    }

    static double TinhDienTich(double dai, double rong)
    {
        return dai * rong;
    }
}
