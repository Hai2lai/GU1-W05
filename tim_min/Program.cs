internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = {1,2,3,4,5,6,7};
        Console.WriteLine("Gia tri lon nhat la : ");
        Console.WriteLine(min(array));
    }
    static int min(int[] array)
    {   
        int min = array[0];
        for(int i=0;i<array.Length;i++)
        {
            if(array[i]<min)
            {
                min = array[i];
            }
        }
        return min;
    }
}