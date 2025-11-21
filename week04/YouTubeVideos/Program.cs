using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();

        Video video1 = new Video(
            "STEM Projects in Huancavelica Schools",
            "RiqchariLab",
            780);

        video1.AddComment(new Comment("María (IE Yauli)",
            "My students loved the robotics example with local materials."));
        video1.AddComment(new Comment("Profesor Luis",
            "Great ideas to bring technology to rural schools in Huancavelica."));
        video1.AddComment(new Comment("Ana",
            "Please share the code of the water sensor project!"));
        videoList.Add(video1);

        Video video2 = new Video(
            "Legends of Huancavelica: Mina de Santa Bárbara",
            "Quipubit Stories",
            540);

        video2.AddComment(new Comment("José",
            "I didn’t know the history behind this mine, beautiful explanation."));
        video2.AddComment(new Comment("Lucía",
            "This will be perfect for my reading class about local culture."));
        video2.AddComment(new Comment("Tourist Guide Hugo",
            "I will recommend this video to visitors who come to Lircay."));
        videoList.Add(video2);

        Video video3 = new Video(
            "Exploring Choclococha Lake by Drone",
            "Huancavelica Adventures",
            620);

        video3.AddComment(new Comment("Carolina",
            "The aerial shots of the lake and mountains are amazing."));
        video3.AddComment(new Comment("Miguel",
            "Please do a video about trekking routes near the lake."));
        video3.AddComment(new Comment("Elena",
            "This video really shows how beautiful Huancavelica is."));
        videoList.Add(video3);

        Video video4 = new Video(
            "Textiles and Technology: Coding with Andean Patterns",
            "STEM Huancavelica",
            810);

        video4.AddComment(new Comment("Rosa (artesana)",
            "Nice connection between traditional textiles and programming."));
        video4.AddComment(new Comment("Diego",
            "I loved the idea of using quipu as inspiration for algorithms."));
        video4.AddComment(new Comment("Valeria",
            "This motivates girls from my community to study technology."));
        videoList.Add(video4);

        foreach (Video video in videoList)
        {
            video.DisplayDetails();
            Console.WriteLine();
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
