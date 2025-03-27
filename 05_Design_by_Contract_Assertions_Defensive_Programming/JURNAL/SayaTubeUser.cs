using System;
using System.Collections.Generic;
using System.Diagnostics;

public class SayaTubeUser
{
    private string username;
    private List<SayaTubeVideo> uploadedVideos;

    public SayaTubeUser(string username)
    {
        Debug.Assert(username != null, "Username tidak boleh null");
        Debug.Assert(username.Length <= 100, "Username maksimal 100 karakter");

        this.username = username;
        this.uploadedVideos = new List<SayaTubeVideo>();
    }

    public void AddVideo(SayaTubeVideo video)
    {
        Debug.Assert(video != null, "Video tidak boleh null");
        Debug.Assert(video.GetPlayCount() < int.MaxValue, "Play count video melebihi batas integer");

        uploadedVideos.Add(video);
    }

    public int GetTotalVideoPlayCount()
    {
        int total = 0;
        foreach (var video in uploadedVideos)
        {
            total += video.GetPlayCount();
        }
        return total;
    }

    public void PrintAllVideoPlaycount()
    {
        Console.WriteLine($"User: {username}");
        int count = 0;
        foreach (var video in uploadedVideos)
        {
            if (count >= 8) break;
            Console.WriteLine($"Video {count + 1} judul: {video.GetTitle()}");
            count++;
        }
    }
}