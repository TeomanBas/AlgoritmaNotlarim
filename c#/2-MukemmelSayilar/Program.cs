internal class Program
{
    private static void Main(string[] args)
    {
        for(int i = 1; i < 1000; i++)
        {
            if(Mukemmel(i))
            {
                Console.WriteLine("mükemmel bir sayı : {0}", i);
            }
        }
        Console.WriteLine(new string('-',20));
       
    }
    public static bool Mukemmel(int sayi)
    {
        int toplam = 0;
        for (int i = 1; i < sayi; i++)
        {
            if(sayi%i == 0)
            {
                toplam += i;
            }
        }
        if(toplam == sayi)
        {
            return true;
        }
        return false;
    }

    
}