using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Education TI";
        job1._company = "San Silvestre School";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Manager TI";
        job2._company = "Huancavelica University";
        job2._startYear = 2022;
        job2._endYear = 2023;


        Job job3 = new Job();
        job3._jobTitle = "Consultor TI";
        job3._company = "Platzi";
        job3._startYear = 2024;
        job3._endYear = 2025;

        Resume myResume = new Resume();
        myResume._name = "Jean C Ordoñez";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);

        myResume.Display();
    }
}