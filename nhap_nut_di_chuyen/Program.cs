
internal class Program
{
    private static void Main(string[] args)
    {   

        // màu của chữ
        /*Console.SetCursorPosition(0,0);
        Console.BackgroundColor=ConsoleColor.DarkBlue;
        Console.ForegroundColor=ConsoleColor.DarkRed;
        Console.Write("hai 2 lai");

        // điều khiển nhận ký tự từ bàn phím
        ConsoleKeyInfo keyInfo;
        do
        {
        keyInfo = Console.ReadKey();
        //Console.WriteLine(keyInfo); // in ký tự mình nhập
        Console.WriteLine(keyInfo.Key.ToString()); // in 2 ký tự mình nhập VD : dD , sS ...
        }while(keyInfo.Key==ConsoleKey.Escape);*/

        while(true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            if(keyInfo.Key==ConsoleKey.UpArrow||keyInfo.Key==ConsoleKey.W)
            {
                Console.WriteLine("di len");
            }else if(keyInfo.Key==ConsoleKey.DownArrow||keyInfo.Key==ConsoleKey.S)
            {
                Console.WriteLine("di xuong");
            }else if(keyInfo.Key==ConsoleKey.RightArrow||keyInfo.Key==ConsoleKey.D)
            {
                Console.WriteLine("di phai");
            }else if(keyInfo.Key==ConsoleKey.LeftArrow||keyInfo.Key==ConsoleKey.A)
            {
                Console.WriteLine("di trai");
            }
        }

    }
}