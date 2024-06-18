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
		private double rate { get; set; }
		private double hours { get; set; }

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
		public double GetSalary()
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

        public string toString()
        {
            return $"Wages ID: {GetId()} \nName: {GetName()} \nAddress: {GetAddress()} \nPhone: {GetPhone()} \nSIN: {GetSin()} \nDate of Birth:{GetDateOfBirth()} \nDepartment: {GetDepartment()} \nRate: {GetRate()} \nHours {GetHours()} \nPay: {GetPay()}";
        }


        //     private double rate;
        //     private double hours;

        //     /**
        //* Creates a PartTime object with default values.
        //*/
        //     public PartTime()
        //     {

        //     }

        //     /**
        //* Creates a PartTime object providing the id, name, address, phone, address, sin, date of birth, department, rate, and hours.
        //* @param id id
        //* @param name name
        //* @param address address
        //* @param phone phone number
        //* @param sin Social Insurance Number
        //* @param dateOfBirth date of birth
        //* @param department department
        //* @param rate rate
        //* @param hours hours
        //*/
        //     public PartTime(string id, string name, string address, string phone, long sin, string dateOfBirth, string department, double rate, double hours) : base(id, name, address, phone, sin, dateOfBirth, department)
        //     {

        //         this.rate = rate;
        //         this.hours = hours;
        //     }

        //     /**
        //* Returns the hourly rate.
        //* @return the hourly rate
        //*/
        //     public double GetRate()
        //     {
        //         return rate;
        //     }

        //     /**
        //* Sets the hourly rate to the hourly rate provided.
        //* @param rate the hourly rate to Set
        //*/
        //     public void SetRate(double rate)
        //     {
        //         this.rate = rate;
        //     }

        //     /**
        //* Returns the hours worked.
        //* @return the hours worked
        //*/
        //     public double GetHours()
        //     {
        //         return hours;
        //     }

        //     /**
        //* Sets the hours to the hours worked.
        //* @param hours the hours worked to Set
        //*/
        //     public void SetHours(double hours)
        //     {
        //         this.hours = hours;
        //     }

        //     /**
        //* Returns the pay.
        //* @return the pay
        //*/
        //     public double GetPay()
        //     {
        //         return rate * hours;
        //     }


        //     public string toString()
        //     {
        //         return "Wages ID =" + GetId() + ", name =" + GetName() + ", address =" + GetAddress()
        //                 + ", phone =" + GetPhone() + ", SIN =" + GetSin() + ", date of birth =" + GetDateOfBirth()
        //                 + ", department =" + GetDepartment() + ", rate =" + GetRate() + ", hours =" + GetHours()
        //                 + ", pay =" + GetPay();
        //     }

    }
}
