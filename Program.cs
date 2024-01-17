using System;
using System.Runtime.ConstrainedExecution;
using TestCSharp_Menu_interativo.Client;

class Program 
{
    static void Main(string[] args)
    {

        Client client = new Client();

        bool loop = true;
        string option;     

        while (loop)
        {
            Console.Clear();
            Console.WriteLine("MENU:\n1 - Register client.\n2 - Close.");

            option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.Clear();

                    Console.WriteLine("Register client:");
                    Console.WriteLine("Name: ");
                    string name = Console.ReadLine();

                    client.Name = name;

                    string clientName = client.Name;

                    Console.WriteLine("Age: ");
                    int age = Convert.ToInt32(Console.ReadLine());

                    client.Age = age;

                    int clientAge = client.Age;

                    Console.WriteLine("CPF: ");
                    string CPF = Console.ReadLine();

                    client.Cpf = CPF;

                    string clientCPF = client.Cpf;

                    Console.WriteLine("\nMENU:\n1 - Show client.\n2 - Back.\n3 - Close.");
                    option = Console.ReadLine();

                    switch (option)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine($"CLIENT:\nName: {clientName}\nAge: {clientAge} years old\nCPF: {clientCPF}");
                            Console.ReadLine();

                            break;

                        case "2":                            
                            break;

                        case "3":
                            loop = false;

                            break;

                        default:
                            Console.WriteLine("Invalid option.");
                            Console.ReadLine();

                            break;
                    }

                    break;

                case "2":                   
                    loop = false;

                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    Console.ReadLine();

                    break;
              
            }
        }
    }
}