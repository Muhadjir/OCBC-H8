using System;

public class String1
{
    public static void Main(string[] args)
    {
        char[] charray = {'1', ' ', 's', 't', 'r', 'i', 'n', 'g', '.'};
        string st1 = new string(charray);
        string st2 = "String Lain.";

        Console.WriteLine(st1);
        Console.WriteLine(st2);

    }
}       