using System;

class Program
{
    static void Main()
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – Berlian Seva Astryana");
        video.PrintVideoDetails();

        Console.WriteLine("\nMenambahkan play count...");
        video.IncreasePlayCount(10000000); // Tambah 10 juta
        video.PrintVideoDetails();

        Console.WriteLine("\nMenguji Overflow...");
        for (int i = 0; i < 25; i++) // Loop untuk menambah play count sampai overflow
        {
            video.IncreasePlayCount(10000000);
        }

        video.PrintVideoDetails();
    }
}
