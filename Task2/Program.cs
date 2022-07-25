using System;
using System.Collections.Generic;
using System.IO;
using Task2;

namespace Task2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Event sorting = new Event();
            sorting.Dfirstnameevent += sorting.Sorted;

            while (true)

                try
                {
                    Console.WriteLine("Выберите как отсортивать список фамилий" +
                      "\n1 - от А - Я" +"\n2 - от Я - А");
                    string number = Console.ReadLine();
                    sorting.DoEvent(number);
                }
                catch (MyExeptions e)
                {

                    Console.WriteLine(e.Message);
                }

        }

    }
}





