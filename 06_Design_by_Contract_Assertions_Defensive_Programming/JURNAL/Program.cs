using System;

class Program
{
    static void Main()
    {
        SayaTubeUser user = new SayaTubeUser("Berlian");

        for (int i = 1; i <= 10; i++)
        {
            SayaTubeVideo video = new SayaTubeVideo($"Review Film {i} oleh Berlian Seva Astryana");
            video.IncreasePlayCount(100000);
            user.AddVideo(video);
        }

        user.PrintAllVideoPlaycount();
    }
}