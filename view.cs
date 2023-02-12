namespace EDU;

public class view
{
    public string ok(int x)
    {
        if (x == 3)
        {
            return "yes";
        }
        return "no";
    }
    
    public void vi(string s)
    {
        string ss = File.ReadAllText(s);
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
          Console.WriteLine("Please make choice\n         1-Unregister course\n         2-Submit soulution\n         3-Back\n");
           int x = Convert.ToInt32(Console.ReadLine());
           Console.Clear();
        
         if (x == 1)
         
           {
               for (int i = 0; i < a.Length-1; i++)
               {
                   string[] z = a[i].Split(".");
                   Console.WriteLine(i+1+")"+"the name of course : "+z[0]+"  the code of course : "+z[1]+"  Creat by doctor : "+z[2]+"\n   " +
                                     " Assignment "+z[4]+" "+z[5]+" - NA/ "+z[6]);
               }
               Console.Write("Please make choice : ");
               int y = Convert.ToInt32(Console.ReadLine());
               File.WriteAllText(s,"");
               for (int i = 0; i < a.Length-1; i++)
               {
                   if (y != i + 1)
                   {
                       File.AppendAllText(s,a[i]+"*");
                   }
               }
           }
         else if(x==2)
         {
             for (int i = 0; i < a.Length-1; i++)
             {
                 string[] z = a[i].Split(".");
                 Console.WriteLine(i+1+")"+"the name of course : "+z[0]+"  the code of course : "+z[1]+"  Creat by doctor : "+z[2]+"\n   " +
                                   " Assignment "+z[4]+" "+z[5]+" - NA/ "+z[6]);
             }
             Console.Write("Please make choice : ");
             int y = Convert.ToInt32(Console.ReadLine());
             File.WriteAllText(s,"");
             Console.ReadLine();
           for (int i = 0; i < a.Length-1; i++)
           {
               if (y == i + 1)
               {
                   string[] z = a[i].Split(".");
                   File.AppendAllText(s,z[0]+"."+z[1]+"."+z[2]+"."+z[3]+"."+z[4]+"."+"Submitted"+"."+z[6]+"*");
               }
               else
               {
                   File.AppendAllText(s, a[i] + "*");
               }
           }
           
         }
        
        
    }
}