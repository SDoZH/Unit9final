using System;



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
    public class MyExeptions1 : ApplicationException
    {
        public MyExeptions1(string message)
            : base(message)
        { }
    }
}


       
    



