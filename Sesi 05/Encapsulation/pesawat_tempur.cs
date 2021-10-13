using System;

class pesawat_tempur:CPesawat
{
        public void terbangtinggi()
        {
            Console.WriteLine("Pesawat tempur dengan nama {0}, yang mempunyai jumlah roda {1}, sedang berada pada ketinggian {2} kaki, dengan membawa jumlah penumpang sebanyak {3} akan meledakkan senjata", this.Nama, this.jumlahRoda, this.ketinggian, this.jumlahPenumpang);
        }

    
}