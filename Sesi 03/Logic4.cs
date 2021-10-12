using System;

public class Logic2
{
    public static void Main(string[] args)
    {
        int a;
        string nama, ulang;
        Console.WriteLine("Hello");
        Console.Write("Masukkan Nama Anda: ");
        nama=Console.ReadLine();
        do
        {   
            Console.Write("Masukkan Nilai Anda: ");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Nama Anda: "+nama);
            if(a<60){
                Console.WriteLine("Nilai Anda E");
            }else if(a>=60 && a<70){
                Console.WriteLine("Nilai Anda D");
            }else if(a>=70 && a<80){
                Console.WriteLine("Nilai Anda C");
            }else if(a>=80 && a<90){
                Console.WriteLine("Nilai Anda B");
            }else if(a>=90 ){
                Console.WriteLine("Nilai Anda A");
            }else{
                Console.WriteLine("Nilai Anda Not Found");
            }
            Console.Write("Apakah Anda Ingin Mengulang [Y/T]? ");
            ulang = Console.ReadLine();
        } while (ulang == "Y" || ulang == "y");
    }
}       