using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //instance objek
            Laptop laptop1 = new Laptop();
            Console.Write("Masukkan merk Laptop: ");
            laptop1.merk = Console.ReadLine();
            Console.Write("Masukkan Kapasitas RAM Laptop: ");
            laptop1.ram = int.Parse(Console.ReadLine());
            Console.Write("Masukkan Kapasitas Memory Laptop: ");
            laptop1.memory = int.Parse(Console.ReadLine());
            Console.WriteLine();
            //akses atribut

            //Tampilan
            Console.WriteLine("\n Merk Laptop adalah {0}", laptop1.merk);
            Console.WriteLine("\n Kapasitas RAM ada {0} GB", laptop1.ram);
            Console.WriteLine("\n Kapasitas Memory ada {0} GB", laptop1.memory);

            //Akses Method
            laptop1.Chatting();
            laptop1.Sosmed();
            laptop1.OnlineShop();

            Console.Read();

        }
    }
}
