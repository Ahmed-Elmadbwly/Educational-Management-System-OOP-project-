namespace EDU;

public class Register
{
    public void reg(string s)
    {
        string ss = File.ReadAllText("r.txt");
        string[] a = ss.Split("*");
        if (a.Length == 0)
        {
            Console.WriteLine("Not find course");
        } 
        for (int i = 0; i < a.Length-1; i++)
        {
            string[] z = a[i].Split(".");
            Console.WriteLine(i+1+")"+"the name of course : "+z[0]+"  the code of course : "+z[1]+"  Creat by doctor : "+z[2]+"\n   " +
                              " Assignment "+z[4]+" "+z[5]+" - NA/ "+z[6]);
        }
        Console.Write("Enter your choice ");
        int x = Convert.ToInt32(Console.ReadLine());
        File.AppendAllText(s,a[x-1]+"*");
        
    }
}