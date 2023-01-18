 public class Resume{
    public string js_name = "";
    public List<Job> js_jobs = new List<Job>();
    public void js_Display(){
        Console.WriteLine($"Name - {js_name}");
        Console.WriteLine("Jobs - ");
        foreach(Job i in js_jobs){
            i.js_Display();
        }
    }
 }