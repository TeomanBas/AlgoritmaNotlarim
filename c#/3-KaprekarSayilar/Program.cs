internal class Program
{
    private static void Main(string[] args)
    {
        //yazdir(Usal(9, 2));
        kaprekarkontrol(9);

    }
    public static double[] Usal(int Sayi, int us)
    {
        double[] sayiussu = new double[1] { Math.Pow(Sayi, us) };
        return sayiussu;
    }
    public static void yazdir(double[] sayidizi)
    {
        for (int i = 0; i < sayidizi.Length; i++)
        {
            Console.WriteLine(sayidizi[i]);
        }
    }
    public static bool kaprekarkontrol(int n)
    {

        // Kareyi hesapla
        int kare = n * n;

        // Basamak sayısını bul
        int basamak = 0;
        while (kare > 0)
        {
            basamak++;
            kare /= 10;
        }

        // Kareyi tekrar hesapla
        kare = n * n;

        // Her basamak için deneme yap
        for (int i = 1; i < basamak; i++)
        {
            // Kareyi i basamağından böl
            int bolum = (int)Math.Pow(10, i);
            int sol = kare / bolum;
            int sag = kare % bolum;

            // Sol ve sağ toplamı n ise Kaprekar sayısıdır
            if (sol + sag == n && sag > 0)
            {
                Console.WriteLine("kaprekar sayı");
                return true;
            }
                
        }

        // Hiçbir basamak için Kaprekar sayısı olmadıysa false döndür
        Console.WriteLine("kaprekar sayı değil");
        return false;
    }
}


