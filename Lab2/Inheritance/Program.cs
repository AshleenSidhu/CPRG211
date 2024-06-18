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
            List<Employee> employees = new List<Employee>();
            string[] lines = File.ReadAllLines("C://Users//ssidh//cprg211//Lab2//Inheritance//resources//employees.txt");

            foreach (string line in lines)
            {
                string[] columns = line.Split(":");
                string id = columns[0];
                char firstNumberOfID = id[0];

                // The first digit of ID is 0-4 then they are salaried employees
                if (firstNumberOfID >= '0' && firstNumberOfID <= '4')
                {
                    employees.Add(new Salaried(columns[0], columns[1], columns[2], columns[3], long.Parse(columns[4]), columns[5], columns[6], Double.Parse(columns[7])));
                }
                else if (firstNumberOfID >= '5' && firstNumberOfID <= '7')
                {
                    employees.Add(new Wages(columns[0], columns[1], columns[2], columns[3], long.Parse(columns[4]), columns[5], columns[6], Double.Parse(columns[7]), Double.Parse(columns[8])));
                }
                else //if (firstNumberOfID >= '8' && firstNumberOfID <= '9')
                {
                    employees.Add(new PartTime(columns[0], columns[1], columns[2], columns[3], long.Parse(columns[4]), columns[5], columns[6], Double.Parse(columns[7]), Double.Parse(columns[8])));
                }

            }

            // Display output
            Console.WriteLine($"The average pay for all employees is: ${AveragePay(employees):F2}");
            Console.WriteLine($"\nThe Wages employee with the highest pay is: {HighestPayWagesEmployee(employees):F2}");
            Console.WriteLine($"\nThe Salaried employee with the lowest pay is: {LowestPaySalariedEmployee(employees):F2}");
            Console.WriteLine($"\nPercentage of Salaried employees is: {PercentageOfSalaried(employees):F2}%");
            Console.WriteLine($"\nPercentage of Wages employees is: {PercentageOfWages(employees):F2}%");
            Console.WriteLine($"\nPercentage of Part Time employees is: {PercentageOfPartTime(employees):F2}%");
        }

        /// <summary>
        /// Calculate and return the average pay for all employees.
        /// </summary>
        /// <param name="employees"></param>
        /// <returns></returns>
        static double AveragePay(List<Employee> employees)
        {
            double totalPay = 0;

            foreach (Employee employee in employees)
            {
                if (employee is Salaried)
                {
                    totalPay += ((Salaried)employee).GetPay();
                }
                else if (employee is Wages)
                {
                    totalPay += ((Wages)employee).GetPay();
                }
                else if (employee is PartTime)
                {
                    totalPay += ((PartTime)employee).GetPay();
                }
            }

            return totalPay / employees.Count;
        }

        /// <summary>
        /// Find and return the wages employee with the highest pay.
        /// </summary>
        /// <param name="employees"></param>
        /// <returns></returns>
        static string HighestPayWagesEmployee(List<Employee> employees)
        {
            // Find the wages employee with the highest pay
            double highestPay = 0;
            string highestPayEmployee = "";

            // Loop through all employees
            foreach (Employee employee in employees)
            {
                // Check if the employee is a wages employee
                for (int i = 0; i < employees.Count(); i++)
                {
                    // If the employee is a wages employee, check if their pay is higher than the current highest pay
                    Employee emp = employees[i];
                    if (emp is Wages)
                    {
                        Wages wageEmployee = (Wages)emp;
                        if (wageEmployee.GetPay() > highestPay)
                        {
                            highestPay = wageEmployee.GetPay();
                            highestPayEmployee = wageEmployee.GetName();
                        }
                    }
                }

            }
            // Return the wages employee with the highest pay
            return $"\n{highestPayEmployee} \nPay: ${highestPay}";
           
        }

        /// <summary>
        /// Find and return the salaried employee with the lowest pay.
        /// </summary>
        /// <param name="employees"></param>
        /// <returns></returns>
        static string LowestPaySalariedEmployee(List<Employee> employees)
        {
            // Find the salaried employee with the lowest pay
            double lowestPay = double.MaxValue;
            string lowestPayEmployee = "";

            // Loop through all employees
            foreach (Employee employee in employees)
            {
                // Check if the employee is a salaried employee
                if (employee is Salaried)
                {
                    // If the employee is a salaried employee, check if their pay is lower than the current lowest pay
                    Salaried salaryEmployee = (Salaried)employee;
                    if (salaryEmployee.GetPay() < lowestPay)
                    {
                        lowestPay = salaryEmployee.GetPay();
                        lowestPayEmployee = salaryEmployee.GetName();
                    }
                }
            }
            // Return the salaried employee with the lowest pay
            return $"\n{lowestPayEmployee} \nPay: ${lowestPay}";
        }

        /// <summary>
        /// Calculate and return the percentage of salaried employees.
        /// </summary>
        /// <param name="employees"></param>
        /// <returns></returns>
        static double PercentageOfSalaried(List<Employee> employees)
        {
            int salariedCount = 0;

            // Loop through all employees
            foreach (Employee employee in employees)
            {
                // Check if the employee is a salaried employee
                if (employee is Salaried)
                {
                    // If the employee is a salaried employee, increment the salaried count
                    salariedCount++;
                }
            }

            // Return the percentage of salaried employees
            return (double)salariedCount / employees.Count * 100;
        }

        /// <summary>
        /// Calculate and return the percentage of wages employees.
        /// </summary>
        /// <param name="employees"></param>
        /// <returns></returns>
        static double PercentageOfWages(List<Employee> employees)
        {
            int wagesCount = 0;

            foreach (Employee employee in employees)
            {
                // Check if the employee is a wages employee
                if (employee is Wages)
                {
                    wagesCount++;
                }
            }

            return (double)wagesCount / employees.Count * 100;
        }

        /// <summary>
        /// Calculate and return the percentage of part-time employees.
        /// </summary>
        /// <param name="employees"></param>
        /// <returns></returns>
        static double PercentageOfPartTime(List<Employee> employees)
        {
            int partTimeCount = 0;

            // Loop through all employees
            foreach (Employee employee in employees)
            {
                // Check if the employee is a part-time employee
                if (employee is PartTime)
                {
                    partTimeCount++;
                }
            }

            return (double)partTimeCount / employees.Count * 100;
        }
    }
}
