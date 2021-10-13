using System;

namespace Encapsulation
{
    class Program:overriding
    {
        public override void print()
            {
                Console.WriteLine("Overiding 2 yaaa ");
                Console.WriteLine("Hasil Pengurangan angka {0} - angka {1} = {2}", bil1, bil2, (bil1-bil2));
                Console.WriteLine("Hasil Pembagian angka {0} : angka {1} = {2}", bil1, bil2, (bil1/bil2));
            }
        static void Main(string[] args)
        {
            string ulang;
            do
            {
                Console.Clear();
                Console.WriteLine("Selamat Datang di Sesi 5");
                Console.WriteLine("Silahkan pilih Menu nya ");
                Console.WriteLine("1. Pesawat Tempur ");
                Console.WriteLine("2. Overloading ");
                Console.WriteLine("3. Overriding ");
                Console.WriteLine("4. About C# ");
                Console.WriteLine("5. Exit ");
                Console.Write("Masukkan pilihan anda: ");
                int pilih = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (pilih)
                {
                    case 1:{
                        Console.WriteLine("Soal Pesawat Tempur");
                        CPesawat pesawat1 = new CPesawat();
                        pesawat_tempur pswt = new pesawat_tempur();
                        Console.Write("Masukkan Nama Maskapai Pesawat: ");
                        pesawat1.Nama = Console.ReadLine();
                        Console.Write("Masukkan Ketinggian Terbang Pesawat: ");
                        pesawat1.ketinggian = Console.ReadLine();
                        Console.Write("Masukkan Jumlah Roda Pesawat: ");
                        pesawat1.jumlahRoda = int.Parse(Console.ReadLine());
                        Console.Write("Masukkan Jumlah Penumpang Pesawat: ");
                        pesawat1.jumlahPenumpang = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("Masukkan Nama Maskapai Pesawat Tempur: ");
                        pswt.Nama = Console.ReadLine();
                        Console.Write("Masukkan Ketinggian Terbang Pesawat Tempur: ");
                        pswt.ketinggian = Console.ReadLine();
                        Console.Write("Masukkan Jumlah Roda Pesawat Tempur: ");
                        pswt.jumlahRoda = int.Parse(Console.ReadLine());
                        Console.Write("Masukkan Jumlah Penumpang Pesawat Tempur: ");
                        pswt.jumlahPenumpang = int.Parse(Console.ReadLine());

                        pesawat1.terbang();
                        pesawat1.sudahterbang();
                        pswt.terbangtinggi();
                    break;}
                    case 2:{
                        Console.WriteLine("Soal Over Loading");
                        overloading ovl = new overloading();
                        Console.Write("Masukkan Nama Anda: ");
                        ovl.nama = Console.ReadLine();
                        Console.Write("Masukkan No. Telp Anda: ");
                        ovl.notelp = double.Parse(Console.ReadLine());

                    break;}
                    case 3:{
                        Console.WriteLine("Soal Over Riding");
                        Console.Write("Masukkan angka pertama Overide 1: ");
                        int a = int.Parse(Console.ReadLine());
                        Console.Write("Masukkan angka kedua Overide 1: ");
                        int b = int.Parse(Console.ReadLine());
                        Console.Write("Masukkan angka pertama Overide 2: ");
                        int a1 = int.Parse(Console.ReadLine());
                        Console.Write("Masukkan angka kedua Overide 2: ");
                        int b1 = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        overriding ovr = new overriding();
                        ovr.bilangan(a, b);
                        ovr.print();
                        Console.WriteLine();
                        ovr = new Program();
                        ovr.bilangan(a1, b1);
                        ovr.print();

                    break;}
                    case 4:{
                        Console.WriteLine("About C#");
                        Console.WriteLine("Halloooo, saya Muchamad Muhadjir asal dari Surabaya.");
                        Console.WriteLine("Materi Awal Bootcamp adalah C#");
                        Console.WriteLine("Bahasa C# sangat mudah daripada bahasa sebelumnya yang saya pakai");
                        Console.WriteLine("Dari Sesi 1 sampai Sesi 5 saya tertarik dengan C#");
                        Console.WriteLine("Saya Pasti Bisa menguasai bahasa C#");
                        Console.WriteLine("#TAYTB");

                    break;}
                    case 5:{
                        Console.WriteLine("Terima Kasih telah berkunjung. Sampai Jumpa");
                        Environment.Exit(0);

                    break;}
                    
                    default:{
                        Console.WriteLine("Maaf Pilihan Anda Tidak Tersedia");
                    break;}
                }
                Console.Write("Apakah Anda ingin kembali ke menu [y/n]?");
                ulang = Console.ReadLine();
            } while (ulang == "y" || ulang =="Y");
            
            //Pesawat
            
            // Console.Read();
        }
    }
}
