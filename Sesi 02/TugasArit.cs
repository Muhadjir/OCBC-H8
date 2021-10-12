using System;

public class TugasString
{
     public static void Main(string[] args)
     {
         double angka1, angka2, angka3, hasil1, hasil2, hasil3, hasil4, hasil5, rata;
         Console.WriteLine("Tugas Arit");
         Console.Write("Masukkan Angka 1: ");
         angka1=double.Parse(Console.ReadLine());
         Console.Write("Masukkan Angka 2: ");
         angka2=double.Parse(Console.ReadLine());
         Console.Write("Masukkan Angka 3: ");
         angka3=double.Parse(Console.ReadLine());
         hasil1=angka1+angka2;
         hasil2=angka1-angka2;
         hasil3=angka1*angka2;
         hasil4=angka1/angka2;
         hasil5=angka1%angka2;
         rata=(angka1 + angka2 + angka3)/3.0;
         Console.WriteLine();
         Console.WriteLine("Hasil Penjumlahan: "+hasil1);
         Console.WriteLine("Hasil Pengurangan: "+hasil2);
         Console.WriteLine("Hasil Perkalian: "+hasil3);
         Console.WriteLine("Hasil Pembagian: "+hasil4);
         Console.WriteLine("Hasil Sisa Bagi: "+hasil5);
         Console.WriteLine("Hasil Rata-Rata: "+rata);
         Console.ReadLine();
     }
}