using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        job1._startYear = "2020";
        job1._workType ="Part-Time";
        job1._endYear = "2022";

        Job job2 = new Job();
        job2._jobTitle = "Senior manager";
        job2._company = "Apple";
        job2._startYear = "2023";
        job2._workType ="Full-Time";
        job2._endYear = "On-going";

        

        Resume myResume = new Resume();
        myResume._name = "Abraham James W";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();


        
        
    }
}