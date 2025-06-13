using System;

namespace tpmodul2_2311104067
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bagian A - Pengecekan huruf vokal atau konsonan
            Console.Write("Masukkan satu huruf: ");
            char huruf = Convert.ToChar(Console.ReadLine().ToUpper()); // memastikan huruf kapital

            if ("AIUEO".Contains(huruf))
            {
                Console.WriteLine($"Huruf {huruf} merupakan huruf vokal");
            }
            else if (char.IsLetter(huruf))
            {
                Console.WriteLine($"Huruf {huruf} merupakan huruf konsonan");
            }
            else
            {
                Console.WriteLine("Input bukan huruf yang valid.");
            }

            Console.WriteLine(); // garis kosong untuk pemisah

            // Bagian B - Menampilkan array angka genap
            int[] angkaGenap = { 2, 4, 6, 8, 10 };

            for (int i = 0; i < angkaGenap.Length; i++)
            {
                Console.WriteLine($"Angka genap {i + 1} : {angkaGenap[i]}");
            }

            // Agar console tidak langsung tertutup
            Console.WriteLine("\nTekan sembarang tombol untuk keluar...");
            Console.ReadKey();
        }
    }
}
