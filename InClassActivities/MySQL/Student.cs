using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQL
{
	public class Student
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public double GPA { get; set; }

		public Student(int id, string name, double gPA)
		{
			Id = id;
			Name = name;
			GPA = gPA;
		}

	}
}
