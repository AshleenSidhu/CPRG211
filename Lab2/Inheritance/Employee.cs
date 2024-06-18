using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Employee
    {
        // Properties of employee
        private string id;
        private string name;
        private string address;
        private string phone;
        private long sin;
        private string dateOfBirth;
        private string department;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Employee() { }

        /// <summary>
        /// Constructor for Employees
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="address"></param>
        /// <param name="phone"></param>
        /// <param name="sin"></param>
        /// <param name="dateOfBirth"></param>
        /// <param name="department"></param>
        public Employee(string id, string name, string address, string phone, long sin, string dateOfBirth, string department)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.sin = sin;
            this.dateOfBirth = dateOfBirth;
            this.department = department;
        }

        /// <summary>
        /// returns id
        /// </summary>
        /// <returns></returns>
        public string GetId()
        {
            return id;
        }

        /// <summary>
        /// sets id
        /// </summary>
        /// <param name="id"></param>
        public void SetId(string id)
        {
            this.id = id;
        }

        /// <summary>
        /// returns address
        /// </summary>
        /// <returns></returns>
        public string GetAddress()
        {
            return address;
        }

        /// <summary>
        /// sets address
        /// </summary>
        /// <param name="address"></param>
        public void SetAddress(string address)
        {
            this.address = address;
        }

        /// <summary>
        /// returns phone
        /// </summary>
        /// <returns></returns>
        public string GetPhone()
        {
            return phone;
        }

        /// <summary>
        /// sets phone
        /// </summary>
        /// <param name="phone"></param>
        public void SetPhone(string phone)
        {
            this.phone = phone;
        }

        /// <summary>
        /// returns name
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return name;
        }

        /// <summary>
        /// sets name
        /// </summary>
        /// <param name="name"></param>
        public void SetName(string name)
        {
            this.name = name;
        }
     
        /// <summary>
        /// returns SIN
        /// </summary>
        /// <returns></returns>
        public long GetSin()
        {
            return sin;
        }

        /// <summary>
        /// sets SIN
        /// </summary>
        /// <param name="sin"></param>
        public void SetSin(long sin)
        {
            this.sin = sin;
        }

        /// <summary>
        /// returns date of birth 
        /// </summary>
        /// <returns></returns>
        public string GetDateOfBirth()
        {
            return dateOfBirth;
        }

        /// <summary>
        /// sets the date of birth
        /// </summary>
        /// <param name="dateOfBirth"></param>
        public void SetDateOfBirth(string dateOfBirth)
        {
            this.dateOfBirth = dateOfBirth;
        }

        /// <summary>
        /// returns department
        /// </summary>
        /// <returns></returns>
        public string GetDepartment()
        {
            return department;
        }

        /// <summary>
        /// sets department
        /// </summary>
        /// <param name="department"></param>
        public void SetDepartment(string department)
        {
            this.department = department;
        }

        /// <summary>
        /// Displays employee information
        /// </summary>
        /// <returns>string</returns>
        public string tostring()
        {
            return "\nEmployee ID:" + GetId() + 
                " \nName=" + GetName() + 
                " \nAddress=" + GetAddress() + 
                " \nPhone)=" + GetPhone() + 
                " \nSIN=" + GetSin() + 
                " \nDate of birth=" + GetDateOfBirth() + 
                " \nDepartment=" + GetDepartment();
        }




    }
}
