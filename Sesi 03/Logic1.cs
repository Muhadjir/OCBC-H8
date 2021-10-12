using System;

public class Logic1
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");
        int a, b;
        string nama;
        Console.Write("Masukkan Nama Anda: ");
        nama=Console.ReadLine();
        Console.Write("Masukkan bilangan 1: ");
        a=int.Parse(Console.ReadLine());
        Console.Write("Masukkan bilangan 2: ");
        b=int.Parse(Console.ReadLine());
        Console.WriteLine("");
        Console.WriteLine("Nama Anda: "+nama);
        Console.WriteLine("Bilangan 1: "+a);
        Console.WriteLine("Bilangan 2: "+b);
        if(a>b){
            Console.WriteLine("Bilangan 1 Lebih Besar daripada Bilangan 2");
        }else if(a<b){
            Console.WriteLine("Bilangan 2 Lebih Besar daripada Bilangan 1");
        }else{
            Console.WriteLine("Bilangan 1 Sama dengan Bilangan 2");
        }
    }
}       