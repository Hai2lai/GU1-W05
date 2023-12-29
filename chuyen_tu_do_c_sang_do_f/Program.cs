using System;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Hãy nhập lựa chọn của bạn");
        Console.WriteLine("1: chuyển từ độ C sang độ F");
        Console.WriteLine("2: chuyển từ độ F sang độ C");
        Console.WriteLine("3: THOÁT");

        int x =32;
        while(x!=0)
        {
            Console.Write("Lựa chọn của bạn là : ");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Group1();
                    break;

                case 2:
                    Group2();
                    break;

                case 3:
                    x=0;
                    Console.WriteLine("Cảm ơn bạn đã sử dụng chương trình.");
                    break;

                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        }

    }

    static int c_sang_f(int a)
    {
        int f = (a * 9 / 5) + 32;
        return f;
    }

    static int f_sang_c(int a)
    {
        int c = ((a - 32) * 5 / 9);
        return c;
    }
    static void Group1()
    {
        Console.Write("Nhập độ C: ");
        int c = int.Parse(Console.ReadLine());
        int f = c_sang_f(c);
        Console.WriteLine($"{c} độ C = {f} độ F");
    }
    static void Group2()
    {
        Console.Write("Nhập độ F: ");
        int F = int.Parse(Console.ReadLine());
        int C = f_sang_c(F);
        Console.WriteLine($"{F} độ F = {C} độ C");
    }
}