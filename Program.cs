using System.Numerics;

namespace Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Viet code tinh dien tich, chu vi Hv, Hcn.
            Console.WriteLine("Tinh dien tich hinh vuong");
            Console.Write("Canh = ");
            BigInteger canh= int.Parse(Console.ReadLine());
            Console.WriteLine("Dien tich hinh vuong la: {0}", canh * canh);
        }
    }
}
