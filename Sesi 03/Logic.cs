using System;

public class Logic
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");
        int n, k, j, x;
        Console.Write("Masukkan banyak bilangan: ");
         n=int.Parse(Console.ReadLine());
        Console.WriteLine("Pattern "+n);
        // for(int i=1; i<=n; i++)
        // {
        //     for(j=n; j>i; j--)
        //     {
        //         Console.Write(" ");
        //     }
        //     for(k=1; k<=i; k++)
        //     {
        //         Console.Write(k);
        //     }
        //     for(x=i-1; x>=1; x--)
        //     {
        //         Console.Write(x);
        //     }
        //     Console.WriteLine("");
        // }

        for(int i=n; i>=1; i--)
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
    }
}       