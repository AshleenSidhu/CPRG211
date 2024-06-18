using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class PartTime : Employee
    {
        private double rate;
        private double hours;

		/// <summary>
		/// Default constructor
		/// </summary>
		public PartTime() 
		{
			this.rate = 15;
			this.hours = 20;
		}

		/// <summary>
		/// Defined constructor that creates PartTime object
		/// </summary>
		/// <param name="id"></param>
		/// <param name="name"></param>
		/// <param name="address"></param>
		/// <param name="phone"></param>
		/// <param name="sin"></param>
		public PartTime(string id, string name, string address, string phone, long sin, string dateOfBirth, string department, double rate, double hours) : base(id, name, address, phone, sin, dateOfBirth, department)
		{
			this.rate = rate;
			this.hours = hours;
		}

		/// <summary>
		/// Find salary of part time employee
		/// </summary>
		/// <returns></returns>
		public double GetPay()
		{
            // pay is calculated based on hourly rate * work hours with no overtime paid
            return rate * hours;
		}

        /// <summary>
        /// returns rate
        /// </summary>
        /// <returns>rate</returns>
        public double GetRate()
        {
            return rate;
        }

        /// <summary>
        /// sets rate
        /// </summary>
        /// <param name="rate"></param>
        public void SetRate(double rate)
        {
            this.rate = rate;
        }

        /// <summary>
        /// returns hours
        /// </summary>
        /// <returns>hours</returns>
        public double GetHour()
        {
            return hours;
        }

        /// <summary>
        /// sets hours
        /// </summary>
        /// <param name="hours"></param>
        public void SetHours(double hours)
        {
            this.hours = hours;
        }

        public string ToString()
        {
            return $"\nWages ID: {GetId()} \nName: {GetName()} \nAddress: {GetAddress()} \nPhone: {GetPhone()} \nSIN: {GetSin()} \nDate of Birth:{GetDateOfBirth()} \nDepartment: {GetDepartment()} \nRate: {GetRate()} \nHours {GetHour()} \nPay: {GetPay()}";
        }

    }
}
