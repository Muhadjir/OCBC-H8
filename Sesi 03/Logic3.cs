using System;

public class Logic3
{
    public static void Main(string[] args)
    {
        bool x= false;
        string user, pass, ulang;

        do
        {   
            Console.WriteLine("Hello");
            Console.Write("Masukkan Username: ");
            user=Console.ReadLine();
            Console.Write("Masukkan Password: ");
            pass=Console.ReadLine();

            if(user == "ocbc" && pass == "bootcamp"){
                Console.WriteLine("Anda Berhasil Login");
                x=false;
            }else {
                Console.WriteLine("Username atau Password Salah. COba Lagi!");
                x=true;
            }
            
        } while (x);
    }
}       