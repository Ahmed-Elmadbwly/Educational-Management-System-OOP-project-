namespace EDU
{
    public class Class
    {
        static void Main()
        {
            string ss;
            do
            {
                Console.WriteLine("*********** Welcome to main list **********\nPlease make a choice :\n       1-Login\n       2-Sign up\n       3-Shutdown system");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (x == 1)
                {
                    Login l = new Login();
                    l.login();
                }
                else if (x == 2)
                {
                    sign_up s = new sign_up();
                    s.signup();
                }
                else
                {
                    return;
                }
                Console.WriteLine("You want to go a main list enter yes");
                    ss = Console.ReadLine();
                    Console.Clear();

            } while (ss == "yes" );
        }
    }
    
}