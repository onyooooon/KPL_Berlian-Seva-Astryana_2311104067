using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_2311104067
{
    class Penjumlahan
    {
        static void Main()
        {
            Penjualan<int> penjumlahan = new Penjumlahan<int>();
            int hasil = penjumlahan.JumlahTigaAngka(12, 34, 56);
            Console.Writeline($"Hasil Penjumlahan: {hasil}");

            SimpleDataBase<int> database = new SimpleDataBase<int>();
            database.AddNewData(12);
            database.AddNewData(34);
            database.AddNewData(56);
            database.PrintAllData();
        }
    }
}
