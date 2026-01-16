using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        
        Resume myResume = new Resume();
        myResume._name = "Henry D. James";

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Google";
        job1._startYear = "2020";
        job1._endYear = "2024";

        Job job2 = new Job();
        job2._jobTitle = "UI UX Designer";
        job2._company = "Microsoft";
        job2._startYear = "2018";
        job2._endYear = "2020";

        Job job3 = new Job();
        job3._jobTitle = "Customer Support Agent";
        job3._company = "Apple";
        job3._startYear = "2015";
        job3._endYear = "2018"; 

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);

        myResume.DisplayResumeInfo();     
    }
}