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
        public Wages()
        {
            rate = 0;
			hours = 0;
        }

		/// <summary>
		/// The constructor for the Wages class.
		/// </summary>
		/// <param name="id"></param>
		/// <param name="name"></param>
		/// <param name="address"></param>
		/// <param name="phone"></param>
		/// <param name="sin"></param>
        public Wages(string id, string name, string address, string phone, long sin, string dateOfBirth, string department, double rate, double hours)
        {
            this.rate = rate;
			this.hours = hours;
        }

		/// <summary>
		/// For claculaing the pay.
		/// </summary>
		/// <returns></returns>
		public double GetPay()
        {
            const double REGULAR_HOURS = 40;
            const double OVERTIME_RATE = 1.5;

            if (hours <= REGULAR_HOURS)
            {
                return rate * hours;
            }
            else
            {
                return rate * REGULAR_HOURS + rate * OVERTIME_RATE * (hours - REGULAR_HOURS);
            }
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
		/// String that displays wage.
		/// </summary>
		/// <returns>string that displays wage</returns>
		public override string ToString()
		{
			return $"Wages ID: {GetId()} \nName: {GetName()} \nAddress: {GetAddress()} \nPhone: {GetPhone()} \nSIN: {GetSin()} \nDate of Birth:{GetDateOfBirth()} \nDepartment: {GetDepartment()} \nRate: {GetRate()} \nHours {GetHours()} \nPay: {GetPay()}";
		}

   //     private double rate;
   //     private double hours;
   //     private const double REGULAR_HOURS = 40;
   //     private const double OVERTIME_RATE = 1.5;

   //     /**
		 //* Creates a Wages object with default values.
		 //*/
   //     public Wages()
   //     {

   //     }

   //     /**
		 //* Creates a Wages object providing the id, name, address, phone, address, sin, date of birth, department, rate, and hours.
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
   //     public Wages(String id, String name, String address, String phone, long sin, String dateOfBirth, String department, double rate, double hours) :
   //         base(id, name, address, phone, sin, dateOfBirth, department)
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
   //         if (hours <= REGULAR_HOURS)
   //         {
   //             return rate * hours;
   //         }
   //         else
   //         {
   //             return rate * REGULAR_HOURS + rate * OVERTIME_RATE * (hours - REGULAR_HOURS);
   //         }
   //     }


   //     public String toString()
   //     {
   //         return "Wages ID =" + GetId() + ", name =" + GetName() + ", address =" + GetAddress()
   //                 + ", phone =" + GetPhone() + ", SIN =" + GetSin() + ", date of birth =" + GetDateOfBirth()
   //                 + ", department =" + GetDepartment() + ", rate =" + GetRate() + ", hours =" + GetHours()
   //                 + ", pay =" + GetPay();
   //     }


    }
}
