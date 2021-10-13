using System;

public class CPesawat
{
       //Atribute/variable
        public string Nama;
        private string Ketinggian;

        private int JumlahPenumpang, JumlahRoda;

        public string ketinggian
        {
            get{return Ketinggian;}
            set{Ketinggian = value;}
        }
        public int jumlahPenumpang
        {
            get{return JumlahPenumpang;}
            set{JumlahPenumpang = value;}
        }
        public int jumlahRoda
        {
            get{return JumlahRoda;}
            set{JumlahRoda = value;}
        }
        public void terbang()
        {
            Console.WriteLine("Pesawat dengan nama {0} sedang take off", this.Nama);
        }
        public void sudahterbang()
        {
            Console.WriteLine("Pesawat sekarang berada di ketinggian {0} Kaki", this.Ketinggian);
        }

    
}