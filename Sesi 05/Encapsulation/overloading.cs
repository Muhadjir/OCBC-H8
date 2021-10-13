using System;
// namespace Encapsulation
// {
    public class overloading
    {
        // class data
        // {
            public string nama;
            public double notelp;
            public void print(string nama)
            {
                this.nama = nama;
                Console.WriteLine("Nama Anda adalah : {0}", this.nama);
            }
            public void print(double notelp)
            {
                this.notelp = notelp;
                Console.WriteLine("No. Telp : {0}", this.notelp);
            }

            // //untuk overriding yaaa
            // public int bil1, bil2;
            // public void bilangan(int ak1, int ak2)
            // {
            //     bil1 = ak1;
            //     bil2 = ak2;
            // }
            // public virtual void print()
            // {
            //     Console.WriteLine("Overiding 1 ");
            //     Console.WriteLine("Hasil Penjumlahan angka {0} + angka {1} = {2}", bil1, bil2, (bil1+bil2));
            //     Console.WriteLine("Hasil Perkalian angka {0} * angka {1} = {2}", bil1, bil2, (bil1*bil2));
            // }
        // }
    }
// }