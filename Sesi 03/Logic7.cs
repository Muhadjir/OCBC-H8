using System;

public class Logic7
{
    public static void Main(string[] args)
    {
        // int a=10;
        // string nama, ulang;
        // Console.WriteLine("Hello");
        // Console.Write("Masukkan Nama Anda: ");
        // nama=Console.ReadLine();
        // while(a<20){
        //     Console.WriteLine("Angka "+a);
        //     a++;
        // }
        int x=0;
        for(int i=1; i<=10; i++){
            
            Console.WriteLine("Angka "+(i+x));
            x=i;
        }
    }
}       