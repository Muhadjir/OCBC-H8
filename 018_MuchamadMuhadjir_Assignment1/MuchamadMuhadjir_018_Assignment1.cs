using System;

public class MuchamadMuhadjir_018_Assignment1
{
    public static void Main(string[] args)
    {
        string ulang;
        do
        {
            Console.Clear();
            int angka, k, x, j, n;
            Console.WriteLine("Selamat Datang di Assignment 1");
            Console.WriteLine("Nama Lengkap: Muchamad Muhadjir");
            Console.WriteLine("Kode Peserta: FSDO001ONL018");
            Console.WriteLine("Alamat : JL. Pucangan 4/32-A Surabaya");
            Console.WriteLine();
            Console.WriteLine("Silahkan memilih Soal ^_^");
            Console.WriteLine("1. Segitiga Alphabet.");
            Console.WriteLine("2. Segitiga Angka.");
            Console.WriteLine("3. Program Faktorial.");
            Console.WriteLine("4. Program BalikAngka.");
            Console.WriteLine("5. Converter Angka ke String.");
            Console.Write("Masukkan Pilihan Anda: ");
            angka = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (angka)
            {
                case 1:{
                    Console.Write("Masukkan banyak alphabet: ");
                    n=int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    for(int i=1; i<=n; i++)
                    {
                        for(j=n; j>i; j--)
                        {
                            Console.Write(" ");
                        }
                        for(k=1; k<=i; k++)
                        {
                            char c = (char)(k+64);
                            // char c = Convert.ToChar(65);
                            Console.Write(c);
                        }
                        for(x=i-1; x>=1; x--)
                        {
                            char c = (char)(x+64);
                            // char c = Convert.ToChar(65);
                            Console.Write(c);
                        }
                        Console.WriteLine("");
                    }

                break;}
                case 2:{
                    Console.Write("Masukkan banyak bilangan: ");
                    n=int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    for(int i=1; i<=n; i++)
                    {
                        for(j=n; j>i; j--)
                        {
                            Console.Write(" ");
                        }
                        for(k=1; k<=i; k++)
                        {
                            Console.Write(k);
                        }
                        for(x=i-1; x>=1; x--)
                        {
                            Console.Write(x);
                        }
                        Console.WriteLine("");
                    }

                break;}
                case 3:{
                    

                break;}
                case 4:{
                    

                break;}
                case 5:{
                    

                break;}
                default:{
                    Console.WriteLine("Mohon Maaf Pilihan Anda Tidak Tersedia");

                break;}
            }

            Console.WriteLine();
            Console.Write("Apakah Anda ingin mengulang ? ");
            ulang = Console.ReadLine();
            
        } while (ulang == "Ya" || ulang == "ya");

    }

}