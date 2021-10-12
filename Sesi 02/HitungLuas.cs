using System;

public class HitungLuas
{
     public static void Main(string[] args)
     {
         double p, l, Luas;
         Console.WriteLine("Luas Persegi Panjang");
         Console.Write("Masukkan panjang: ");
         p=double.Parse(Console.ReadLine());
         Console.Write("Masukkan lebar: ");
         l=double.Parse(Console.ReadLine());
         Luas=p*l;
         Console.WriteLine("Panjang Persegi Panjang Adalah "+p);
         Console.WriteLine("Lebar Persegi Panjang Adalah "+l);
         Console.WriteLine("Luas Persegi Panjang Adalah "+Luas);
     }
}