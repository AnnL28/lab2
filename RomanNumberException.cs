using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    public class RomanNumberException : Exception
    {
        public RomanNumberException(string message)
        {
            Console.WriteLine(message);
        }

    }
}
