using System;
using System.Collections.Generic;
using System.Text;
using Unit9final;

namespace Task1
{
    public class AgeMin : ArgumentException
    {
        public AgeMin(string message)
            : base(message)
        { }
    }
    public class NaneException : ArgumentException
    {
        public NaneException(string message)
            : base(message)
        { }
    }
    public class AgeMax : ArgumentException
    {
        public AgeMax(string message)
            : base(message)
        { }
    }
    public class PhoneEX : ArgumentException
    {
        public PhoneEX(string message)
            : base(message)
        { }
    }
}

