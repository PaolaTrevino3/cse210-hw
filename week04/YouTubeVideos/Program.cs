using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Morning Skincare Routine for Beginners", "Glow Beauty", 480 );
        video1.AddComment(new Comment("Sophia", "This routine is simple and easy to follow!"));
        video1.AddComment(new Comment("Liam", "I liked that you explained each step clearly."));
        video1.AddComment(new Comment("Isabella", "This helped me understand what to use in the morning!"));
        video1.AddComment(new Comment("Noah", "Great video! I will try this routine tomorrow."));

        Video video2 = new Video("Best ingredients for Healthy Skin", "Skin Academy", 620);
        video2.AddComment(new Comment("Ava", "The explanation about hyaluronic acid was really helpful!"));
        video2.AddComment(new Comment("Ethan", "I didn't know that niacinamide could help with acne!"));
        video2.AddComment(new Comment("Camille", "This video made skincare ingredients easier to understand."));
        video2.AddComment(new Comment("Mason", "Great information without being overwhelming or confusing!"));

        Video video3 = new Video("Common Skincare Mistakes to Avoid", "Clear Skin Channel", 540);
        video3.AddComment(new Comment("Grace", " I wish I had seen this sooner! I was making some of these mistakes without realizing it."));
        video3.AddComment(new Comment("Amelia", "i didn't know that over-washing could actually damage your skin!"));
        video3.AddComment(new Comment("Oliver", "very useful advice, especially for beginners like me!"));
        video3.AddComment(new Comment("Valentina", "This heped me fix my nighttime routine and my skin has improved so much!"));

        Video video4 = new Video("Night Skincare Routine for Glowing Skin", "beauty care tips", 700);
        video4.AddComment(new Comment("Evelyn", "the nighttime routine sounds very relaxing and effective!"));
        video4.AddComment(new Comment("Victor", "I like how explained the orders of the products."));
        video4.AddComment(new Comment("Samantha", "this gave me ideas for improving my routine and getting better results!"));
        video4.AddComment(new Comment("Lucas", "simple, clear, and very helpful! I will try this routine tonight."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            video.Display();

        }
    }
}