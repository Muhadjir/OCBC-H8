using System;
// namespace Encapsulation
// {
    public class overriding
    {
        // class data
        // {
            public int bil1, bil2;
            public void bilangan(int ak1, int ak2)
            {
                bil1 = ak1;
                bil2 = ak2;
            }
            public virtual void print()
            {
                Console.WriteLine("Overiding 1 ");
                Console.WriteLine("Hasil Penjumlahan angka {0} + angka {1} = {2}", bil1, bil2, (bil1+bil2));
                Console.WriteLine("Hasil Perkalian angka {0} * angka {1} = {2}", bil1, bil2, (bil1*bil2));
            }
            // public override void print()
            // {
            //     Console.WriteLine("Overiding 2 yaaa ");
            //     Console.WriteLine("Hasil Pengurangan angka {0} - angka {1} = {2}", bil1, bil2, (bil1-bil2));
            //     Console.WriteLine("Hasil Pembagian angka {0} : angka {1} = {2}", bil1, bil2, (bil1/bil2));
            // }
        // }
    }
// }