////using System;
////using System.Collections;
////using System.Collections.Generic;
////public class Program
//{
////    public static void Main()
////    {
//        int[] arr = { 0, 1, 2, 3, 4 };
//        List<int> list = new List<int>();
//        for (int x = 5; x < 10; x++)
//        {
//            list.Add(x);
//        }
//        ProcessItems<int>(arr);
//        ProcessItems<int>(list);
//    }
//    static void ProcessItems<T>(IList<T> coll)
//    {
//        // IsReadOnly returns True for the array and False for the List.
//        System.Console.WriteLine
//        ("IsReadOnly returns {0} for this collection.",
//        coll.IsReadOnly);
//        // The following statement causes a run-time exception for the
//        // array, but not for the List.
//        //coll.RemoveAt(4);
//        foreach (T item in coll)
//        {
//            System.Console.Write(item.ToString() + " ");
//        }
//        System.Console.WriteLine();
//    }
//}

using System;
using System.Collections;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Inisialisasi array integer
        int[] angkaArray = { 0, 1, 2, 3, 4 };

        // Inisialisasi list dan menambahkan angka 5 hingga 9
        List<int> angkaList = new List<int>();
        for (int i = 5; i < 10; i++)
        {
            angkaList.Add(i);
        }

        // Memproses array dan list menggunakan method generik
        ProcessItems(angkaArray);
        ProcessItems(angkaList);
    }

    /// <summary>
    /// Menampilkan informasi koleksi dan isinya.
    /// </summary>
    /// <typeparam name="T">Tipe data dari elemen koleksi</typeparam>
    /// <param name="collection">Koleksi yang akan diproses</param>
    static void ProcessItems<T>(IList<T> collection)
    {
        // Menampilkan apakah koleksi bersifat ReadOnly
        Console.WriteLine("IsReadOnly returns {0} for this collection.", collection.IsReadOnly);

        // Menampilkan setiap item dalam koleksi
        foreach (T item in collection)
        {
            Console.Write(item.ToString() + " ");
        }

        Console.WriteLine();
    }
}
