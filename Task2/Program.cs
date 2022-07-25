using System;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> firstName = new List<string>
            {
                "Сидоров",
                "Петров",
                "Антонов",
                "Григорьев",
                "Петухов",
                "Иванов"
            };

            firstName.Sort();

            foreach (string str in firstName)
                Console.WriteLine(str);

            Console.ReadLine();
        }
    }
    public class FirstNameList
    {
        public string FirstName { get; set; } = "";
    }
}
