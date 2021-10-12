using System;

namespace hello_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            string nama;
            int umur, tinggi, berat;
            Console.WriteLine("Hello World!");
            Console.WriteLine("Pendaftaran Data Diri");
            Console.Write("Masukkan Nama: ");
            nama = Console.ReadLine();
            Console.Write("Masukkan Alamat: ");
            var alamat = Console.ReadLine();
            Console.Write("Masukkan Umur: ");
            umur = int.Parse(Console.ReadLine());
            Console.Write("Masukkan Tinggi: ");
            tinggi = int.Parse(Console.ReadLine());
            Console.Write("Masukkan Berat: ");
            berat = int.Parse(Console.ReadLine());

            
            Console.WriteLine();
            Console.WriteLine("Biodata");
            Console.WriteLine($"Nama: {nama}");
            Console.WriteLine($"Alamat: {alamat}");
            Console.WriteLine("Umur: "+umur+" tahun");
            Console.WriteLine("Tinggi: "+tinggi+" cm");
            Console.WriteLine("Berat: "+berat+" kg");



        }
    }
}
