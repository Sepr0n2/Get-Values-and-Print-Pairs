using System;
class Program
{
    static void Main()
    {
        int n = 0;
        while (n <= 0)
        {

            Console.WriteLine("Bu program girdiğin sayıların çift olanlarını yazdıracak");
            Console.WriteLine("Kaç sayı girecen!");
            string? inputn = Console.ReadLine();
            if (int.TryParse(inputn, out n) && n > 0)
            {
                System.Console.WriteLine("Sayı başarıyla alındı");
            }
            else
            {
                System.Console.WriteLine("POZİTİİFFFF GİİİRRRRRR");
                n = 0;
            }
        }
        int[] sayidizisi = new int[n];
        for (int i = 0; i < n; i++)
        {
            System.Console.WriteLine("{0}.sayıyı gir", i + 1);
            sayidizisi[i] = int.Parse(Console.ReadLine());
        }
         System.Console.WriteLine("Çift sayılar");
        foreach (var sayi in sayidizisi)
        {
            if (sayi % 2 == 0)
            {
                Console.WriteLine(sayi);
            }
        }
                Console.WriteLine("Çıkmak için bir tuşa basın...");
                Console.ReadKey();
    }
}