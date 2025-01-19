using System;


usingnamespace t1;
{

    class()
{
    static void Main(string[] args)
    {
        while (a == 1)
        {
            int option;
            string SavedPassword, SavedName, name, password;
            console.WriteLine("Select One option\n\n");
            console.WriteLine("1.Login\n");
            console.WriteLine("2.Create Account\n");
            console.WriteLine("3.exit\n");
            option = console.ReadLine();
            int i = 1;
            if (option == 1)
            {
                while (i == 1)
                {
                    console.WriteLine("Enter User Name\n");
                    name = console.ReadLine();
                    console.WriteLine("Enter Password\n");
                    password = console.ReadLine();
                    if (name == "SavedName" && password == "SavedPassword")
                    {
                        console.Write("Welcome");
                        return 0;
                    }
                    else
                    {

                        console.WriteLine("Invalid Crerdentials\n");
                        console.WriteLine("1.Try again\n2.Go back");
                        i = console.ReadLine();
                    }
                    if (i == 2) break;
                }//end of while loop
            }//end of if statement
            if (option == 2)
            {
                console.WriteLine("Enter User Name\n");
                SavedUsername = console.ReadLine();
                console.WriteLine("Enter Password\n");
                SavedPassword = console.ReadLine();
            }
            if (option == 3)
            {
                return 0;
            }
        }//end of outer while loop


    }//end of satiyc void
}//end of class
}//end of namesapce 