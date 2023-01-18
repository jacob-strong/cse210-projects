 public class Job{
    public string js_company = "";
    public string js_jobTitle = "";
    public int js_startYear = 0;
    public int js_endYear = 0;
    public void js_Display(){
        Console.WriteLine($"{js_jobTitle} ({js_company}) {js_startYear}-{js_endYear}");
    }
 }