using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {   
        Console.OutputEncoding=Encoding.UTF8;// câu lệnh để viết tiếng việt
        Console.WriteLine("điền 2 giá trị mà bạn muốn tính tổng : ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int k = Tong(a,b);
        Console.WriteLine("vậy tổng của 2 số là : "+k);
        viet();
    }

    static int Tong(int a , int b)
    {
        int sum = a+b;
        return sum;
    }
    static int Tong(int a , int b,int c)      //lúc này nếu chúng ta gọi 3 đơn vị ở trên hàm main thì nó sẽ dùng hàm này thay vì hàm trên
    {
        int sum = a+b+c;
        return sum;
    }
    static string Tong(string a , string b)   //nếu chúng ta điền chữ ở trên hàm main nó sẽ sử dụng hàm này
    {
        string sum = a+b;
        return sum;
    }
    static void viet()
    {   
        Console.WriteLine("tạm biệt bà con cô bác");
    }
}