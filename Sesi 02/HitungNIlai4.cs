using System;

public class HitungNilai4
{
     public static void Main(string[] args)
     {
         
         Console.WriteLine("Tugas Hitung Nilai 4");
         Console.Write("Enter Your Age: ");
         int age = int.Parse(Console.ReadLine());
         Console.Write("Password: ");
         string pass = Console.ReadLine();
         
         bool isAdult = age>18;
         bool isPassValid = pass == "OCBC";

         if(isAdult && isPassValid){
             Console.WriteLine("Welcome to the OCBC!");
         }else{
             Console.WriteLine("Sorry, Try Again!");
         }

         
         
         

     }
}