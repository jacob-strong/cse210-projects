using System;

class Program
{
    static void Main(string[] args)
    {
        Job js_job1 = new Job();
        js_job1.js_company = "Techno Union";
        js_job1.js_jobTitle = "Grand Foreman";
        js_job1.js_startYear = 2002;
        js_job1.js_endYear = 2005;

        Job js_job2 = new Job();
        js_job2.js_company = "Separtist Alliance";
        js_job2.js_jobTitle = "Counsellor";
        js_job2.js_startYear = 2002;
        js_job2.js_endYear = 2005;

        Resume wat_tambor = new Resume();
        wat_tambor.js_name = "Wat Tambor";
        wat_tambor.js_jobs.Add(js_job1);
        wat_tambor.js_jobs.Add(js_job2);

        wat_tambor.js_Display();
    }
}