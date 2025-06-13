using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Masukkan nama Anda: ");
        string nama = Console.ReadLine();
        Console.WriteLine($"Selamat datang, {nama}!");

        int[] arr = new int[50];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i;
            string tambahan = "";

            if (i % 2 == 0 && i % 3 == 0)
                tambahan = " #$#$";
            else if (i % 2 == 0)
                tambahan = " ##";
            else if (i % 3 == 0)
                tambahan = " $$";

            Console.WriteLine($"{arr[i]}{tambahan}");
        }

        Console.Write("Masukkan angka (1 - 10000): ");
        string nilaiString = Console.ReadLine();
        int nilaiInt = Convert.ToInt32(nilaiString);

        if (ApakahPrima(nilaiInt))
            Console.WriteLine($"Angka {nilaiInt} merupakan bilangan prima");
        else
            Console.WriteLine($"Angka {nilaiInt} bukan merupakan bilangan prima");
    }

    static bool ApakahPrima(int angka)
    {
        if (angka <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(angka); i++)
        {
            if (angka % i == 0)
                return false;
        }

        return true;
    }
}
