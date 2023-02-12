namespace EDU;

public class creat
{
    public void cr( string s)
    {
        Console.Write("Enter name of course : ");
        string name = Console.ReadLine();
        Console.Write("Enter code of course : ");
        string co = Console.ReadLine();
        Console.Write("Enter assignment name : ");
        string n = Console.ReadLine();
        Console.Write("Enter assignment grade : ");
        int g = int.Parse(Console.ReadLine());
        string ssd = "Not submitted";
        File.AppendAllText("r.txt",name+"."+co+"."+s+"."+n+"."+ssd+"."+g+"*");
     
    }
}