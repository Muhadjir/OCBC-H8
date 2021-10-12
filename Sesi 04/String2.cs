using System;
using System.Globalization;

public class String2
{
    public static void Main(string[] args)
    {
        string st1 = "Untuk Pemrograman .NET, C# adalah #1.";
        string st2 = "Untuk Pemrograman .NET, C# adalah #1.";
        string st3 = "string C# sangat tangguh.";
        string stAtas, stBawah;
        int hasil, idx;

        Console.WriteLine("String 1: "+st1);
        Console.WriteLine("Panjang String 1: "+st1.Length);

        stBawah = st1.ToLower(CultureInfo.CurrentCulture);
        stAtas = st1.ToUpper(CultureInfo.CurrentCulture);

        Console.WriteLine("Versi Huruf Kecil String 1: "+stBawah);
        Console.WriteLine("Versi Huruf Besar String 1: "+stAtas);
        Console.WriteLine();

        Console.WriteLine("Menampilkan string1, char demi char");
        for(int i=0; i<st1.Length; i++)
            Console.Write(st1[i]);
        Console.WriteLine("\n");

        if(st1 == st2)
            Console.WriteLine("String1 == String2");
        else
            Console.WriteLine("String1 != String2");
        
        if(st1 == st3)
            Console.WriteLine("String1 == String3");
        else
            Console.WriteLine("String1 != String3");
        
        hasil = string.Compare(st1, st3, StringComparison.CurrentCulture);
        if(hasil == 0)
            Console.WriteLine("string1 dan string3 sama");
        else if(hasil < 0)
            Console.WriteLine("string1 kurang dari string3");
        else
            Console.WriteLine("string1 lebih besar dari string3");
        
        Console.WriteLine();

        st2= "Satu Dua Tiga Satu";

        idx = st2.IndexOf("Satu", StringComparison.Ordinal);
        Console.WriteLine("Indeks kemunculan pertama dari Satu: "+idx);

        idx = st2.LastIndexOf("Satu", StringComparison.Ordinal);
        Console.WriteLine("Indeks kemunculan terakhir dari Satu: "+idx);



    }
}       