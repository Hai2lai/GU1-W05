
using System.Text;

internal class Program
{
public static int DemSoLanXuatHien(char kyTu, string chuoi)
{
    int dem = 0;
    foreach (char lol in chuoi)
    {
        if (lol == kyTu)
        {
            dem++;
        }
    }
    return dem;
}

public static void Main()
{   
    Console.OutputEncoding=Encoding.UTF8;
    Console.WriteLine("Nhập chuỗi:");
    string chuoi = Console.ReadLine();

    Console.WriteLine("Nhập ký tự:");
    char kyTu = Console.ReadKey().KeyChar;

    int soLanXuatHien = DemSoLanXuatHien(kyTu, chuoi);
    Console.WriteLine("\nSố lần xuất hiện của ký tự '{0}' trong chuỗi là: {1}", kyTu, soLanXuatHien);

    Console.ReadLine();
}
}