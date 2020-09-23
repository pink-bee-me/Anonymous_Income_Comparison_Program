using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Income_Comparison_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person 1
            Console.WriteLine("Anonymous Income Comparison Program \nPerson 1");
            Console.WriteLine("Hourly Rate: ");
            int hourlyRate1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours Worked per Week: ");
            int hoursPerWeek1 = Convert.ToInt32(Console.ReadLine());
            //Person 2
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate: ");
            int hourlyRate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours Worked per Week: ");
            int hoursPerWeek2 = Convert.ToInt32(Console.ReadLine());
            //Annual Salaries
            string annualSalary1 =Convert.ToString((hourlyRate1 * hoursPerWeek1) * 52);
            string annualSalary2 =Convert.ToString((hourlyRate2 * hoursPerWeek2) * 52);
            bool compareP1AndP2 = Convert.ToInt32(annualSalary1) > Convert.ToInt32(annualSalary2);
            Console.WriteLine("Annual Salary of Person 1:\n " + annualSalary1);
            Console.WriteLine("Annual Salary of Person 2:\n " + annualSalary2);
            Console.WriteLine("Does Person 1 make more money than Person 2 ?\n" + compareP1AndP2);
            Console.ReadLine();


        }
    }
}
