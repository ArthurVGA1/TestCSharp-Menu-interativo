using System;
using TestCSharp_Menu_interativo.Client;

class Program 
{
    static void Main()
    {
        Client client = new Client();
        string? option;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Choose one of the options:\n1 - Register client.\n2 - Show client.\n3 - Close.");

            option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine("Register client:");
                    client.SetClient();
                    break;

                case "2":
                    Console.WriteLine("Show client:");
                    client.GetClient();
                    break;

                case "3":
                    Console.WriteLine("Close");
                    Environment.Exit(0);
                    break;
            }
        }
    }
}