using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    public class RomanNumberException : Exception
    {
        public void NullException(string message)
        {
            Console.WriteLine(message);
        }
        public void DifException(string message)
        {
            Console.WriteLine(message);
        }

    }
}
