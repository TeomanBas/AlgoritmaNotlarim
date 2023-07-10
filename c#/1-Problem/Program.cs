internal class Program
{
    private static void Main(string[] args)
    {
        bool kontrol = true;
        int toplam = 0;
        int sayi = 0;
        int eskitoplam = 0;
        int eskisayi= 0;
        bool eksisay = false;

        while (kontrol)
        {
            eskisayi = sayi;
            Console.WriteLine("bir sayı giriniz");
            sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi >0)
            {
                toplam = toplam + sayi;
                Console.WriteLine("Toplam : {0,5}",toplam);
                //Console.WriteLine("Sayı : {0,5}", sayi);

            }
            else
            {
                if (eksisay==false)
                {
                    eksisay = true;
                    toplam = toplam - eskisayi;
                    Console.WriteLine("Toplam : {0,5}", toplam);
                }
                else
                {
                    eskitoplam = toplam;
                    toplam = 0;
                    Console.WriteLine("Eski Toplam : {0,5}", eskitoplam);

                }
            }
            Console.WriteLine("yeni sayı için entere basınız.");
            Console.ReadKey();
            Console.Clear();
        }
    }

}