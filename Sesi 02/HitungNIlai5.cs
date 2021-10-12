using System;

public class HitungNilai5
{
     public static void Main(string[] args)
     {
         double angka1, angka2, angka3, rata;
         Console.WriteLine("Tugas Hitung Nilai 5");
         Console.Write("Username: ");
         string user = Console.ReadLine();
         Console.Write("Password: ");
         string pass = Console.ReadLine();
         Console.Write("Enter Your Age: ");
         int age = int.Parse(Console.ReadLine());
         Console.Write("Gender: ");
         string gen = Console.ReadLine();
         Console.Write("Married Status: ");
         string stat = Console.ReadLine();

         stat = stat == "y" ? "Maried" : stat == "t" ? "Single" : "Error";
         gen = gen == "p" ? "Woman" : gen == "l" ? "Man" : "Error";

         Console.WriteLine();
         Console.Write("Masukkan Angka 1: ");
         angka1=double.Parse(Console.ReadLine());
         Console.Write("Masukkan Angka 2: ");
         angka2=double.Parse(Console.ReadLine());
         Console.Write("Masukkan Angka 3: ");
         angka3=double.Parse(Console.ReadLine());
         rata=(angka1 + angka2 + angka3)/3.0;


         Console.WriteLine();
         bool isAdult = age>18;
         bool isUserValid = user == "Muhadjir";
         bool isPassValid = pass == "OCBC";

         if(isUserValid && isAdult && isPassValid){
             Console.WriteLine("Welcome to the OCBC!");
             Console.WriteLine("Username: "+user);
             Console.WriteLine("Umur: "+age);
             Console.WriteLine("Gender: "+gen);
             Console.WriteLine("Status: "+stat);
             Console.WriteLine("Total Nilai: "+(angka1 + angka2 + angka3));
             Console.WriteLine("Rata-Rata Nilai: "+rata);

         }else{
             Console.WriteLine("Sorry, Try Again!");
         }

         
         
         

     }
}