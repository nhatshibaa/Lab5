using System;
using System.Runtime.Serialization;

namespace Lab5_2
{
    internal class Program
    {
        [Serializable]
        public class AmountException : Exception
        {
            public string personName;
            public double Salary { get; set; }
            public double Bonus { get; set; }
            public string Rank { get; set; }
            public AmountException()
            {
                if (Salary < 60000 && Rank == "Senior Lecture")
                {
                    Console.WriteLine("Senior Lecture get more than 60,000 salary!");
                }
            }

            public AmountException(string message) : base(message)
            {
            }

            public AmountException(string message, Exception innerException) : base(message, innerException)
            {
            }
            
        }
        public static void Main(string[] args)
        {
            try
            {
                AmountException amountException = new AmountException();
                amountException.Salary = 50000;
                amountException.Rank = "Junior";
            }
            catch (AmountException e)
            {
                throw new AmountException(e.Message);
            }
        }
    }
}