using System;

public class HelloWorld
{
     public static void Main(string[] args)
     {
         Console.WriteLine("Hello World!");
         Console.WriteLine("Hello Nama Saya Muchamad Muhadjir");
         Console.WriteLine("Selamat Datang di Program Bootcamp OCBC");
         Console.WriteLine("Tahap 1 dan 2 saya akan belajar C#");

         string nama_customer="foxi";
         double harga1=10.000, harga2=5.000, harga3=20.000;
         int jumlah1=10, jumlah2=7, jumlah3=13;

         double total1=harga1*jumlah1, total2=harga2*jumlah2, total3=harga3*jumlah3;
         double totalsemua=total1+total2+total3;
         int jumlahsemua=jumlah1+jumlah2+jumlah3;

         Console.WriteLine();
         Console.WriteLine("Nama Customer: "+nama_customer);
         Console.WriteLine("Barang 1 berjumlah: "+jumlah1+" dengan harga Rp. "+harga1+" yang harus dibayar sebesar Rp. "+total1);
         Console.WriteLine("Barang 2 berjumlah: "+jumlah2+" dengan harga Rp. "+harga2+" yang harus dibayar sebesar Rp. "+total2);
         Console.WriteLine("Barang 3 berjumlah: "+jumlah3+" dengan harga Rp. "+harga3+" yang harus dibayar sebesar Rp. "+total3);
         Console.WriteLine();
         Console.WriteLine("Jumlah semua barang adalah "+jumlahsemua);
         Console.WriteLine("Total yang harus dibayarkan sebesar Rp. "+totalsemua);

         Console.WriteLine();
     }
}