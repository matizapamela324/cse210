using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.\n");
        Job job1 = new Job();
        Resume myResume = new Resume();
        job1._jobTitle = "Software developer";
        job1._company = "javax";
        job1._startYear = 2020;
        job1._endYear = 2025;
        Job job2 = new Job();
        job2._jobTitle = "fullstack developer";
        job2._company = "XYZ Inc";
        job2._startYear = 2018;
        job2._endYear = 2023;

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._name = "pamela matiza";

        myResume.Display();
    }
}