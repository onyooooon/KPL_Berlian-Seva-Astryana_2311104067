class Program
{
    static void Main()
    {
        Penjumlahan<int> penjumlahan = new Penjumlahan<int>();
        int hasil = penjumlahan.JumlahTigaAngka(12, 34, 56);
        Console.WriteLine($"Hasil Penjumlahan: {hasil}");

        SimpleDataBase<int> database = new SimpleDataBase<int>();
        database.AddNewData(12);
        database.AddNewData(34);
        database.AddNewData(56);
        database.PrintAllData();
    }
}

