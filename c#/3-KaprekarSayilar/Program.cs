internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine(kaprekarsayibul(1, 10000)); 
    }
    public static string kaprekarsayibul(int baslangic,int bitis)
    {
        string kaprekarsayilar = "";
        for (int i = baslangic; i <= bitis; i++)
        {
            if (kaprekarkontrol(i) == true)
            {
                kaprekarsayilar += i+", ";
            }
        }
        return kaprekarsayilar;
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

                return true;
            }
        }
        // Hiçbir basamak için Kaprekar sayısı olmadıysa false döndür

        return false;
    }
}


