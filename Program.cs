using System; 


namespace main2{


    class Program{
    static void Main(string[] args){

        DateTime t = new DateTime(2011,8,15,3,8,15);
        System.Console.WriteLine( t.DayOfWeek);
        System.Console.WriteLine( t.Day);
        string d = t.ToShortDateString();
        System.Console.WriteLine(d);
        string g  = t.ToString("yyyy-p-MM-dd-p- HH:mm:ss");
        System.Console.WriteLine(g);
        DateTime now = DateTime.Now;
        DateTime n1 = now.AddHours(50);
        System.Console.WriteLine(n1);
    }

}}
