using System;

namespace Oop_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 3;
            Person[] person = new Person[total];
            for (int i = 0; i < total; i++)
            {
                person[i] = new Person()
                {
                    Name = Console.ReadLine()
                }
                ;

            }
            for (int i = 0; i < total; i++)
            {
                Console.WriteLine(person[i].ToString());
            }



            Console.ReadKey();
        }
    }
    public class Person
    {
        public string Name;
        public new string ToString()
        {
            return Name;
        }
    }
}
    

