using System;
using System.Collections.Generic;
using System.Text;
using Task2;

namespace Task2
{

    internal class MyExeptions : ApplicationException
    {
        public string message;
        public MyExeptions(string message) : base(message)
        {
            this.message = message;
        }

    }
}
