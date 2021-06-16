using System;

namespace Lab5_2
{
    public class AmountException : Exception
    {
        private string PersonName;
        private string msg;

        public AmountException(string message, string personName) : base(message)
        {
            this.PersonName = personName;
            this.msg = message;
            PrintError();
        }

        private void PrintError()
        {
            Console.Error.WriteLine($"Error: {msg} | Name: {PersonName}");
        }
    }
}