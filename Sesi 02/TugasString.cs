using System;

public class TugasString
{
     public static void Main(string[] args)
     {
         string nama;
         int umur;
         Console.WriteLine("Tugas String");
         Console.Write("Masukkan Nama Anda ");
         nama=Console.ReadLine();
         Console.Write("Masukkan Alamat Anda ");
         var alamat=Console.ReadLine();
         Console.Write("Masukkan Umur Anda ");
         umur=int.Parse(Console.ReadLine());
         Console.WriteLine();
         Console.WriteLine("Biodata Diri");
         Console.WriteLine($"Nama Saya {nama}");
         Console.WriteLine($"Alamat Saya di {alamat}");
         Console.WriteLine($"Umur Saya {umur} tahun");
         Console.ReadLine();
     }
}