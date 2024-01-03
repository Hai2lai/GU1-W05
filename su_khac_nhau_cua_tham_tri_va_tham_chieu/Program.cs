using System.Text;

internal class Program
{
    private static int Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        int value = 5;
        PassByValue(value);
        // Giá trị của "value" vẫn là 5
        Console.WriteLine("Tham trị : "+value); 

        PassByReference(ref value);
        // Giá trị của "value" thay đổi thành 10
        Console.WriteLine("Tham chiếu : "+value);

        // cách không cần dấu cộng
        int a=3;
        Console.WriteLine("a = {0}",a);

        return 0;
    }
    static int PassByValue(int number)
    {
        number = 10; // Không ảnh hưởng đến giá trị ban đầu của biến bên ngoài phương thức(tham trị)
        return(number);
    }

    static int PassByReference(ref int number)
    {
        number = 10; // Thay đổi giá trị của biến ban đầu(tham chiếu)
        return(number);
    }
}
