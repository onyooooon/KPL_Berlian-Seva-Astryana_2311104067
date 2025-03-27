using System;
using System.Diagnostics;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Debug.Assert(title != null, "Judul video tidak boleh null");
        Debug.Assert(title.Length <= 200, "Judul video maksimal 200 karakter");

        Random rand = new Random();
        this.id = rand.Next(10000, 99999); // ID 5 digit
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        Debug.Assert(count > 0, "Jumlah play count harus positif");
        Debug.Assert(count <= 25000000, "Maksimal penambahan play count adalah 25.000.000");

        try
        {
            checked
            {
                this.playCount += count;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: Play count melebihi batas integer.");
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Play Count: {playCount}");
    }

    public string GetTitle()
    {
        return this.title;
    }

    public int GetPlayCount()
    {
        return this.playCount;
    }
}
