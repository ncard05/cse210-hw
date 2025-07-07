using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Resume resume = new Resume();
        resume._name = "Allison Rose";

        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;
        resume._job.Add(job1);


        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;
        resume._job.Add(job2);

        Console.WriteLine($"{resume._job[0]._jobTitle}");

        resume.DisplayResume();
    }
}