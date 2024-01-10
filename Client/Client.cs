using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCSharp_Menu_interativo.Client;

public class Client
{

    public string? name;
    public int age;
    public string? CPF;

    public void SetClient()
    {
        Console.WriteLine("Enter customer details:\nCPF:");
        CPF = Console.ReadLine();
        Console.WriteLine("Name: ");
        name = Console.ReadLine();
        Console.WriteLine("Age: ");
        age = Convert.ToInt32(Console.ReadLine());
    }
    public void GetClient()
    {
        Console.WriteLine($"CPF: {this.CPF}\nName: {this.name}\nAge: {this.age} years");
    }
}


