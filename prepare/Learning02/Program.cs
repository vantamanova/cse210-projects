using System;

var job1 = new Job();
job1._jobTitle = "Software Engineer";
job1._company = "Microsoft";
job1._startYear = 2010;
job1._endYear = 2014;

var job2 = new Job();
job2._jobTitle = "Software Engineer";
job2._company = "Apple";
job2._startYear = 2014;
job2._endYear = 2020;


var myResume = new Resume();
myResume._name = "Vera Antamanova";

myResume._jobs.Add(job1);
myResume._jobs.Add(job2);

myResume.Display();