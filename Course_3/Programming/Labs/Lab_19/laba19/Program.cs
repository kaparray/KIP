using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace laba19
{
    // THIS IS STRUCTURE! This is amazing, but i not in 1960 year. Right now programmers use OOP
    struct client
    {
        public client(int number, string name, double balance)
        {
            this.number = number;
            this.name = name;
            this.balance = balance;
        }
        public int number; 
        public string name;
        public double balance;
        public void report() 
        { 
            Console.WriteLine("\n number={0} name={1} balance={2}" , number, name, balance);
        }
    } 

    class Program
    {
        static void Main()
        {
            client ob1; 
            ob1.number = 11; ob1.name = "Kirill"; ob1.balance = 77.7;
            client ob2 = new client(16, "Misha", -22.5); 
            client оb3; 
            оb3.number = 2;
            оb3.name = "Empty";
            оb3.balance = 0.0;
            ob1.report(); ob2.report(); оb3.report();
            Console.WriteLine("\n Присваивание:");
            client ob4;
            ob4 = ob1; 
            ob1.report();
            ob4.report(); Console.WriteLine();
            ob1.name ="Elephant"; ob1.report();
            ob4.report(); Console.WriteLine();
            
        ob4.name = "Puss in Boots"; ob1.report(); ob4.report();
            System.Threading.Thread.Sleep(1000);
        }
    }
}