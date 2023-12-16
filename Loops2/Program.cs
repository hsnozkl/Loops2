using System.Globalization;

namespace Loops2;

class Program
{
    static void Main(string[] args)
    {
        //While
        //1 den baslayarak consoldan girilen sayiya kadar (sayi dahil) toplayıp ortalama hesaplayıp consola bastırın.
        Console.WriteLine("Lutfen bir sayi giriniz.");
        int sayi = int.Parse(Console.ReadLine());
        int sayac = 0;
        int toplam = 0;
        while (sayac <= sayi)
        {
            toplam += sayac;
            sayac++;
        }
        Console.WriteLine(toplam / sayi);

        // 'a' dan 'z' ye kadar tum harfleri ekrana bastir.
        char character = 'a';
        while(character <= 'z')
        {
            Console.Write(character);
            character++;
        }
        Console.WriteLine();
        Console.WriteLine("***** Foreach *****");
        string[] arabalar = {"BMW","Ford","Toyota","Nissan"};
        foreach (var araba in arabalar)
        {
            Console.WriteLine(araba);
        }
    }
}
