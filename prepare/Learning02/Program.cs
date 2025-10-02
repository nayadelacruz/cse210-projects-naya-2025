using System;

class Program
{
    static void Main(string[] args)
    {

        Job job1 = new Job();
        job1._company = "Google";
        job1._jobTitle = "Quality Assurance Enginer";
        job1._startYear = 2015;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "Software Developer";
        job2._startYear = 2020;
        job2._endYear = 2023;

        /*job1.Display();
        job2.Display();
        Console.WriteLine(job1._company);*/

        Resume myResume = new Resume();
        myResume._name = "Nayade De la cruz";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        /*Console.WriteLine(myResume._jobs[0]._jobTitle);*/
        myResume.Display();
    }
}