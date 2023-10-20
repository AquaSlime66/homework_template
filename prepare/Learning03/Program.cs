using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Job job1 = new Job("Company Inc", "Lead Developer", 2014, 2018);
        job1.Display();

        Job job2 = new Job("Walmart", "Floor Inspector", 1854, 2019);
        job2.Display();

        Job job3 = new Job("Bethesda", "Boot Licker", 2010, 2023);
        

        Resume joe_resume = new Resume("Todd Howard");
        joe_resume.AddJob(job1);
        joe_resume.AddJob(job2);
        joe_resume.AddJob(job3);
        joe_resume.DisplayResume();

    }
}