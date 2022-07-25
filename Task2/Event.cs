using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    public class Event
    {
        FirstName firstName = new FirstName();
        public event Dfirstname Dfirstnameevent;
        public delegate void Dfirstname(string number);

        public void DoEvent(string number)
        {
            Dfirstnameevent(number);
        }
        public void Sorted(string number)
        {
            _ = int.TryParse(number, out int temp);

            if (temp != 1 && temp != 2)
            {
                throw new MyExeptions("Неккоректное значение");
            }
            switch (temp)
            {
                case 1:
                    ShowSortedA();
                    break;
                case 2:
                    ShowSortedB();
                    break;
            }
        }
        public void ShowSortedA()
        {
            Console.WriteLine();
            firstName.listfirstName.Sort();
            foreach (var e in firstName.listfirstName)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();
        }
        public void ShowSortedB()
        {
            Console.WriteLine();
            firstName.listfirstName.Reverse();
            foreach (var e in firstName.listfirstName)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();

        }

    }
}
