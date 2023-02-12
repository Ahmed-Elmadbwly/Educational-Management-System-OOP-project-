using System.Runtime.CompilerServices;

namespace EDU;

public class Login
{
    public int r { get; set; }
    public void login()
    {
        string o = "",oo="";
       
            string ss = "";
            Console.WriteLine("************ Welcome to secound list ***************** \nPlease make a choice :\n       1-Doctor\n       2-student\n");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.Write("Please enter user name and password :\nuser name :");
            string name = Console.ReadLine();
            Console.Write("password :");
            string pa = Console.ReadLine();
            Console.Clear();
        
            bool ok = true;
            if (x == 1)
            {
                string s = File.ReadAllText("d.txt");
                string[] a = s.Split("*");
                for (int i = 0; i < a.Length - 1; i++)
                {
                    string[] z = a[i].Split(".");
                    if (z[1] == name && z[2] == pa)
                    {
                        Console.Write("Welcome "+z[0]);
                        Console.WriteLine(" ,You login in successfully");
                        ss = z[0];
                        ok = false;
                        break;
                    }
                }

                if (ok)
                {
                    Console.WriteLine("You shold sign frist");
                    oo = "yes";
                }
            }
            else if (x == 2)
            {
                string s = File.ReadAllText("s.txt");
                string[] a = s.Split("*");
                for (int i = 0; i < a.Length - 1; i++)
                {
                    string[] z = a[i].Split(".");
                    if (z[1] == name && z[2] == pa)
                    {
                        Console.Write("Welcome "+z[0]);
                        Console.WriteLine(" ,You login in successfully");
                        ss = z[0];
                        ok = false;
                        break;
                    }
                }

                if (ok)
                {
                    Console.WriteLine("You shold sign frist");
                    oo = "yes";
                }

            }
            do
            {
            if (!ok)
            {
                if (x == 1)
                {
                    Console.WriteLine(
                        "Please make a choice : \n        1-Register in course\n        2-view courses\n        3-Creat course" +
                        "\n        4-Log out");
                    int y = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (ss[ss.Length - 1] != 't' && ss[ss.Length - 2] != 'x' && ss[ss.Length - 3] != 't' &&
                        ss[ss.Length - 4] != '.')
                    {
                        ss += ".txt";
                    }
                    if (y == 1)
                    {
                        Register re = new Register();
                        re.reg(ss);

                    }
                    else if (y == 2)
                    {
                        view v = new view();
                        v.vi(ss);

                    }
                    else if (y == 3)
                    {
                        creat c = new creat();
                        c.cr(ss);
                    }
                    else if (y == 4)
                    {
                        Console.Write("Logging out.");
                        Thread.Sleep(200);
                        Console.Write(".");
                        Thread.Sleep(200);
                        Console.Write(".");
                        Thread.Sleep(200);
                        Console.WriteLine(".");
                        Thread.Sleep(200);
                        break;
                    }
                }
                else
                {
                    Console.WriteLine(
                        "Please make a choice : \n        1-Register in course\n        2-view coursesn\n        3-Log out");
                    int y = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (ss[ss.Length - 1] != 't' && ss[ss.Length - 2] != 'x' && ss[ss.Length - 3] != 't' &&
                        ss[ss.Length - 4] != '.')
                    {
                        ss += ".txt";
                    }
                    if (y == 1)
                    {
                        Register re = new Register();
                        re.reg(ss);

                    }
                    else if (y == 2)
                    {
                        view v = new view();
                        v.vi(ss);

                    }
                    else if (y == 3)
                    {
                        Console.Write("Logging out.");
                        Thread.Sleep(200);
                        Console.Write(".");
                        Thread.Sleep(200);
                        Console.Write(".");
                        Thread.Sleep(200);
                        Console.WriteLine(".");
                        Thread.Sleep(200);
                        break;
                    }

                }
            }

            if (oo == "yes")
            {
                break;
            }
            Console.WriteLine("You want to go a secound list enter yes");
            o = Console.ReadLine();
            Console.Clear();
        } while (o == "yes");

    }
}