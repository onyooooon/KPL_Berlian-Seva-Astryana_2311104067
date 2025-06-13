using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Inisialisasi array berisi angka 0-4
        int[] array = { 0, 1, 2, 3, 4 };

        // Inisialisasi List dan tambahkan angka 5-9
        List<int> list = new List<int>();
        for (int i = 5; i < 10; i++)
        {
            list.Add(i);
        }

        // Proses array dan list menggunakan metode generik
        ProcessItems(array);
        ProcessItems(list);
    }

    // Method generik untuk memproses dan menampilkan isi koleksi
    static void ProcessItems<T>(IList<T> collection)
    {
        Console.WriteLine("IsReadOnly returns {0} for this collection.", collection.IsReadOnly);

        // Menampilkan isi koleksi
        foreach (T item in collection)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();
    }
}
