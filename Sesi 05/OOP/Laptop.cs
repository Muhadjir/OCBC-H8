using System;
namespace OOP
{
    public class Laptop
    {
        // class Laptop
        // {
            //Atribute/variable
            public string merk;
            public int ram, memory;

            public void Chatting()
            {
                Console.WriteLine("\n{0} sedang chatting", this.merk);
            }
            public void Sosmed()
            {
                Console.WriteLine("\n{0} sedang sosmed", this.merk);
            }
            public void OnlineShop()
            {
                Console.WriteLine("\n{0} sedang online shop", this.merk);
            }

        // }
    }
}