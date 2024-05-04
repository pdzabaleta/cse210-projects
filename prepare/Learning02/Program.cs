using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._company = "Tesla";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2024;
        // job1.Display();

        Job job2  = new Job();
        job2._company = "Apple";
        job2._jobTitle = "UX Designer";
        job2._startYear = 2001;
        job2._endYear = 2015;   
        // job2.Display();


        Resume myresume = new Resume();

        myresume._jobs.Add(job1);
        myresume._jobs.Add(job2);
        myresume._name = "John Doe";
        myresume.DisplayDetails();
    }
}