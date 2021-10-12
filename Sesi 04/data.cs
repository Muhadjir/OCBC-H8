using System;

public class data
{
    public static void Main(string[] args)
    {
    //    int x=2;

    //    int y=4;

    //    Kendaraan mobil = new Kendaraan();

    //    //deklarasi variabel array kosong
    //    int[] aAngka;
    //    string[] aNama;
    //    object[] aObject;

       //deklarasi variabel array berisi
       int[] aAngka = new int[5];
       string[] aNama = new string[] {"joni", "Meri", "David"};
       object[] aObject = {20.33, "Lorem Ipsum", DateTime.Now, true, 'D'};

       string[] contoh = new string[4] 
       {
           "Motherboard", "Processor", "Power Supply", "Video Card"
       };

       string contoh1 = contoh[3];
       Console.WriteLine(contoh1);
       Console.Write("Press Any Key ....");


    }
}       