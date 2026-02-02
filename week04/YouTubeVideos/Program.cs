using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Console.WriteLine();

        List<Video> videos = new List<Video>();

        Video video1 = new Video();
        video1._title = "Plankton Vs SpongeBob";
        video1._author = "Catoon Network";
        video1._lengthInSeconds = 180;

        Comment v1Comment1 = new Comment();
        v1Comment1._commenterName = "Agbako Jonatus";
        v1Comment1._text = "Cartoon are for kids! Why does an adult like you watch cartoons???";

        Comment v1Comment2 = new Comment();
        v1Comment2._commenterName = "Joy Ezemuo";
        v1Comment2._text = "So funy! Hahaha";

        video1.AddComment(v1Comment1);
        video1.AddComment(v1Comment2);

        videos.Add(video1);

        Video video2 = new Video();
        video2._title = "That one funny clip from The god's must be crazy";
        video2._author = "FunyShow";
        video2._lengthInSeconds = 60;

        Comment v2Comment1 = new Comment();
        v2Comment1._commenterName = "Agba G";
        v2Comment1._text = "Bro that movie was an epic comedy show! I still laugh when i thing about it";

        Comment v2Comment2 = new Comment();
        v2Comment2._commenterName = "Gifty";
        v2Comment2._text = "I can't decide which is funnier, Mr Bones or The god's must be crazy lol";

        video2.AddComment(v2Comment1);
        video2.AddComment(v2Comment2);

        videos.Add(video2);

        Video video3 = new Video();
        video3._title = "Music affects the sould";
        video3._author = "Uplifting Musics";
        video3._lengthInSeconds = 45;

        Comment v3Comment1 = new Comment();
        v3Comment1._commenterName = "Spiritual MAn";
        v3Comment1._text = "So true! that's why we should listen to music tha uplifs and gives off positive vibes and not just some randomly song music!";

        video3.AddComment(v3Comment1);

        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayInfo();
        }
    }
}
