using System;

namespace TestCSharp_Menu_interativo.Client
{
    class Client
    {
        private string name;
        private string cpf; 
        private int age;

        public string Name   
        {
            get { return name; }   
            set { name = value; }  
        }

        public string Cpf  
        {
            get { return cpf; }   
            set { cpf = value; }  
        }

        public int Age   
        {
            get { return age; }   
            set { age = value; }  
        }
    }
}

