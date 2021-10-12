using System;

public class MuchamadMuhadjir_018_Assignment1
{
    public static void Main(string[] args)
    {
        string ulang;
        do
        {
            Console.Clear();
            int angka;
            Console.WriteLine("Selamat Datang di Assignment 1");
            Console.WriteLine("Nama Lengkap: Muchamad Muhadjir");
            Console.WriteLine("Kode Peserta: FSDO001ONL018");
            Console.WriteLine("Alamat : JL. Pucangan 4/32-A Surabaya");
            Console.WriteLine();
            Console.WriteLine("Silahkan memilih Soal ^_^");
            Console.WriteLine("1. Segitiga Alphabet.");
            Console.WriteLine("2. Segitiga Angka.");
            Console.WriteLine("3. Program Faktorial.");
            Console.WriteLine("4. Program Reverse.");
            Console.WriteLine("5. Converter Angka ke String.");
            Console.WriteLine("6. Polindrom.");
            Console.WriteLine("7. Tentang Saya.");
            Console.WriteLine("8. Exit.");
            Console.Write("Masukkan Pilihan Anda: ");
            angka = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (angka)
            {
                case 1:{
                    int k, x, j, n;
                    Console.WriteLine("1. Soal Segitiga Alphabet.");
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
                    int k, x, j, n;
                    Console.WriteLine("2. Soal Segitiga Angka.");
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
                    int h=1;
                    Console.WriteLine("3. Soal Program Faktorial.");
                    Console.Write("Masukkan Nilai Faktorial: ");
                    int n= int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Nilai Faktorial dari "+n+"!= ");

                    for(int i=1; i<=n; i++)
                    {
                        h=h*i;
                        Console.Write(n-(i-1));
                        if(i!=n)
                            Console.Write("*");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Hasil Dari Faktorial "+n+"! = "+h);

                break;}
                case 4:{
                    string input, news;
                    Console.WriteLine("4. Soal Program Reverse.");
                    Console.Write("Masukkan kata atau angka: ");
                    input = Console.ReadLine();
                    char[] charArray = input.ToCharArray();
                    Array.Reverse(charArray);
                    news = new string(charArray);
                    Console.WriteLine();
                    Console.WriteLine("Input : "+input);
                    Console.WriteLine("Reverse : "+news);
                break;}
                case 5:{
                    string input;
                    string[] hurfangka = new string[10]
                    {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
                    Console.WriteLine("5. Soal Converter Angka ke String.");
                    Console.Write("Masukkan angka yang akan di convert: ");
                    input = Console.ReadLine();
                    string[] hasil = new string[input.Length];
                    char[] charInput = input.ToCharArray();

                    for(int i=0; i<charInput.Length; i++)
                    {
                        for(int j=0; j<hurfangka.Length; j++)
                        {
                            if(int.Parse(charInput[i].ToString()) == j)
                            {
                                hasil[i] = hurfangka[j];
                            }
                        }
                    }

                    for(int i=0; i<hasil.Length; i++)
                    {
                        Console.Write(hasil[i]+" ");
                    }
                    Console.WriteLine();
                break;}
                case 6:{
                    Console.WriteLine("6. Soal Polindrom.");
                    string input, news;
                    Console.Write("Masukkan kata: ");
                    input = Console.ReadLine();
                    char[] charArray = input.ToCharArray();
                    Array.Reverse(charArray);
                    news = new string(charArray);
                    Console.WriteLine();
                    if(input == news)
                    {
                        Console.WriteLine("Kata "+input+" Merupakan Polindrom");
                    }
                    else
                    {
                        Console.WriteLine("Kata "+input+" BUKAN Merupakan Polindrom");
                        
                    }                 
                break;}
                case 7:{
                    Console.WriteLine("Assalamu'alaikum Wr. Wb.");
                    Console.WriteLine("Selamat Datang di Menu Tentang Saya ^_^");
                    Console.WriteLine("Perkenalkan, Nama Saya Muchamad Muhadjir.");
                    Console.WriteLine("Saya biasa dipanggil Muhadjir.");
                    Console.WriteLine("Surabaya adalah Kota Kelahiran Saya Loohhh.");
                    Console.WriteLine("Sekaligus tempat tinggal saya saat ini.");
                    Console.WriteLine("Pada 29 April 2021 kemarin, Usia saya 23 tahuuunnn.");
                    Console.WriteLine("Ohyaaa, Kabar bagus nih, Saat ini ....");
                    Console.WriteLine("Saya sedang mengikuti Bootcamp dari OCBC NISP");
                    Console.WriteLine("Minta Do'a nya yaa, semoga lancar sampai selesai.");
                    Console.WriteLine("Dan juga bisa menjadi Karyawan Tetap di OCBC ^_^");
                    Console.WriteLine("Terima Kasih telah mengunjungi Tentang Saya ^_^");
                break;}
                case 8:{
                    Console.WriteLine("Anda Telah Keluar Program! Terima Kasih ^_^");
                    Environment.Exit(0);
                break;}
                default:{
                    Console.WriteLine("Mohon Maaf Pilihan Anda Tidak Tersedia");
                break;}
            }

            Console.WriteLine();
            Console.Write("Apakah Anda ingin kembali ke menu SOAL [Ya/Tidak]? ");
            ulang = Console.ReadLine();
            
        } while (ulang == "Ya" || ulang == "ya");

    }

}