using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Wages : Employee
    {
		private double rate;
		private double hours;

		/// <summary>
		/// Gets the rate.
		/// </summary>
		public Wages() { }

		/// <summary>
		/// The constructor for the Wages class.
		/// </summary>
		/// <param name="id"></param>
		/// <param name="name"></param>
		/// <param name="address"></param>
		/// <param name="phone"></param>
		/// <param name="sin"></param>
        public Wages(string id, string name, string address, string phone, long sin, string dateOfBirth, string department, double rate, double hours) : base(id, name, address, phone, sin, dateOfBirth, department)
        {
            this.rate = rate;
			this.hours = hours;
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

        /// <summary>
        /// For claculaing the pay.
        /// </summary>
        /// <returns></returns>
        public double GetPay()
        {
            if (hours <= 40)
            {
                return rate * hours;
            }
            else
            {
                return rate * 40 + rate * 1.5 * (hours - 40);
            }
        }

        /// <summary>
        /// String that displays wage.
        /// </summary>
        /// <returns>string that displays wage</returns>
        public override string ToString()
		{
			return $"\nWages ID: {GetId()} \nName: {GetName()} \nAddress: {GetAddress()} \nPhone: {GetPhone()} \nSIN: {GetSin()} \nDate of Birth:{GetDateOfBirth()} \nDepartment: {GetDepartment()} \nRate: {GetRate()} \nHours {GetHour()} \nPay: {GetPay()}";
		}

    }
}
