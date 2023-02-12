namespace EDU;

public class sign_up
{
    public void signup()
    {
        Console.WriteLine("Please make a choice :\n       1-Doctor\n       2-student\n");
        int x=Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        Console.Write("Enter name : ");
        string name = Console.ReadLine();
        Console.Write("Enter user name  : ");
        string us = Console.ReadLine();
        Console.Write("Enter password  : ");
        string pa = Console.ReadLine();
        Console.Write("Enter email  : ");
        string em = Console.ReadLine();
        Console.Clear();
        if (x == 1)
        {
          
            File.AppendAllText("d.txt", name + "." + us + "." + pa + "." + em + "*");
            Console.WriteLine("Sign in successfully try to login ");
        }
        else if(x==2)
        {
            File.AppendAllText("s.txt", name + "." + us + "." + pa + "." + em + "*");
            Console.WriteLine("Sign in successfully try to login ");
        }
        else
        {
            Console.WriteLine("Wrong choice");
        }

    }
}