using System;
using System.Xml.Linq;

namespace Inheritance
{
    /// <summary>
    /// Inheritance Lab
    /// </summary>
    /// <remarks>Author: Ashleen Sidhu</remarks>
    /// <remarks>Date: June 17, 2024</remarks>
    internal class Program
    {
        static void Main(string[] args)
        {
            new Manager();

            // Fill a list with objects based on the supllied data
            string[] lines = File.ReadAllLines("employees.txt");

            List<Employee> employee = new List<Employee>();

            foreach (string line in lines)

            // Calculate and return the average weekly pay for all employees.

            // Calculate and return the highest weekly pay for the wage employees, including the name of the employee.

            // Calculate and return the lowest salary for the salaried employees, including the name of the employee.


            // What percentage of the company’s employees fall into each employee category ?
        }
    }
}
