using System;
using System.Runtime.Serialization;

namespace Lab5_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var highSchool = new HighschoolTeacher()
            {
                IdentityNumber = "ID01",
                Name = "Japan",
                BaseSalary = 300,
                Level = 1,
                Bonus = 100,
                IsSenior = false,
                HighSchoolCode = "HS001"
            };
            Console.WriteLine(highSchool.CalculateSalary());
            var university = new UniversityTeacher()
            {
                IdentityNumber = "ID02",
                Name = "Nhat",
                BaseSalary = 60000,
                Level = 2,
                Bonus = 900,
                IsSenior = true,
                EnglishLevel = 2,
                UniversityCode = "UN001"
            };
            Console.WriteLine(university.CalculateSalary());
        }
    }
}