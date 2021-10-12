using System;

public class HitungNilai3
{
     public static void Main(string[] args)
     {
         int angka1, angka2;
         Console.WriteLine("Tugas Hitung Nilai 3");
         Console.Write("Masukkan Angka 1: ");
         angka1=int.Parse(Console.ReadLine());
         Console.Write("Masukkan Angka 2: ");
         angka2=int.Parse(Console.ReadLine());
         Console.WriteLine();
         Console.WriteLine("Hasil Perbandingan");
         Console.WriteLine($"nilai1 > nilai2 = {angka1>angka2}");
         Console.WriteLine($"nilai1 >= nilai2 = {angka1>=angka2}");
         Console.WriteLine($"nilai1 < nilai2 = {angka1<angka2}");
         Console.WriteLine($"nilai1 <= nilai2 = {angka1<=angka2}");
         Console.WriteLine($"nilai1 == nilai2 = {angka1==angka2}");
         Console.WriteLine($"nilai1 != nilai2 = {angka1!=angka2}");
         Console.ReadLine();
     }
}