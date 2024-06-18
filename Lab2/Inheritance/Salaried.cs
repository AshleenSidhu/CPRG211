using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Salaried : Employee
    {
		private double salary;
		public Salaried() 
		{
			salary = 0;
		}

		/// <summary>
		/// Creates Salaried object
		/// </summary>
		/// <param name="id"></param>
		/// <param name="name"></param>
		/// <param name="address"></param>
		/// <param name="phone"></param>
		/// <param name="sin"></param>
		public Salaried(string id, string name, string address, string phone, long sin, string dateOfBirth, string department, double salary) : base(id, name, address, phone, sin, dateOfBirth, department)
        {
            this.salary = salary;
		}

		/// <summary>
		/// returns salary
		/// </summary>
		/// <returns></returns>
		public double GetSalary()
		{
			return salary;
		}

		/// <summary>
		/// Created a setter method for salary
		/// </summary>
		/// <param name="salary"></param>
		public void SetSalary(double salary)
		{
			this.salary = salary;
		}

        /// <summary>
        /// return salary
        /// </summary>
        /// <returns></returns>
        public double GetPay()
        {
            return GetSalary();
        }

		public override string ToString()
		{
            return $"\nSalaried ID:" + GetId() +
                " \nName: " + GetName() +
                " \nAddress: " + GetAddress() +
                " \nPhone: " + GetPhone() +
                " \nSIN: " + GetSin() +
                " \nDate of birth: " + GetDateOfBirth() +
                " \nDepartment: " + GetDepartment() +
                " \nSalary: " + GetSalary() +
                " \nPay: " + GetPay();
        }

    }
}
