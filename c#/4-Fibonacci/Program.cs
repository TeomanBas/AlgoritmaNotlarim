internal class Program
{
    private static void Main(string[] args)
    {
        fibo(18);
    }
    public static void fibo(int sayi)
    {
        int a = 0;
        int b = 1;
        int c = a + b;
        Console.Write(a);
        Console.Write(",");
        Console.Write(b);
        for (int i = 0; i <=sayi; i++)
        {
            Console.Write(",");
            Console.Write(c);
            a = b;
            b = c ;
            c = a + b;
        }
    }
}