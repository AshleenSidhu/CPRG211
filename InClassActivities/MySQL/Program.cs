using MySqlConnector;
using System.Configuration;


namespace MySQL
{
	internal class Program
	{
		static void Main(string[] args)
		{
			MySqlConnectionStringBuilder builder =
			new MySqlConnectionStringBuilder
			{
				Server = "localhost",
				UserID = "root",
				Password = "password",
				Database = "demo1",
			};

			// Create a MySqlConnection object using the connection string built with the provided builder
			MySqlConnection connection =
				new MySqlConnection(builder.ConnectionString);

			// Open the connection to the MySQL database
			connection.Open();

			Console.WriteLine("Database connection is open.");

			//string sql = "SELECT * FROM table";
			//MySqlCommand command = new MySqlCommand(sql, connection);


			// Execute the command and get the data reader
			string sql = "SELECT * FROM students WHERE gpa >= 3.5 AND Id % 2 = 0";
			MySqlCommand command = new MySqlCommand(sql, connection);

			MySqlDataReader reader = command.ExecuteReader();
			List<Student> students = new List<Student>();
			while (reader.Read())
			{
				//id is even number
				int id = reader.GetInt32(0);
				//gpa is higher than 3.5
				double gpa = reader.GetDouble(2);
				string name = reader.GetString(1);
				Student student = new Student(id, name, gpa);
				students.Add(student);

				Console.WriteLine($"Id: {id}, Name: {name}, GPA: {gpa}");
				
			}

			// Close the reader
			reader.Close();

			// Close the connection to the MySQL database
			connection.Close();

			Console.WriteLine("Database connection is closed.");
		}
	}
}
