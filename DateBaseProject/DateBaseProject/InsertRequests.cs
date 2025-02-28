using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateBaseProject
{
    public class InsertRequests
    {
        public void InsertSubjects(SqlConnection connection)
        {
            using (connection=new SqlConnection(@"Data Source=.;Integrated Security=True;
            Trust Server Certificate=True; Initial Catalog=DataBaseProject;"))
            {
                connection.Open();

                Console.WriteLine("Enter subject name: ");
                string subjectName = Console.ReadLine();

                Console.WriteLine("Enter subject price: ");
                double price=double.Parse(Console.ReadLine());

                Console.WriteLine("Enter subject duration: ");
                int duration=int.Parse(Console.ReadLine());

                string insertSubjects = @"INSERT INTO Subjects(name, price, duration)
                VALUES (@subjectName, @price, @duration)";
                using (SqlCommand cmd=new SqlCommand(insertSubjects,connection))
                {
                    cmd.Parameters.AddWithValue("@subjectName", subjectName);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@duration", duration);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void InsertStudents(SqlConnection connection)
        {
            using (connection = new SqlConnection(@"Data Source=.;Integrated Security=True;
            Trust Server Certificate=True; Initial Catalog=DataBaseProject;"))
            {
                connection.Open();

                Console.WriteLine("Enter student name: ");
                string studentName = Console.ReadLine();

                Console.WriteLine("Enter student surname: ");
                string studentSurname = Console.ReadLine();

                Console.WriteLine("Enter student age: ");
                int studentAge = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter student city: ");
                string stuentCity = Console.ReadLine();

                Console.WriteLine("Enter student date of birth: ");
                string studentDateOfBirth = Console.ReadLine();

                string insertStudents = @"INSERT INTO Students(name,surname,age,city,dateOfBirth)
                VALUES(@name,@surname,@age,@city,@dateOfBirth)";

                using (SqlCommand command = new SqlCommand(insertStudents, connection))
                {
                    command.Parameters.AddWithValue("@name", studentName);
                    command.Parameters.AddWithValue("@surname", studentSurname);
                    command.Parameters.AddWithValue("@age",studentAge);
                    command.Parameters.AddWithValue("@city",stuentCity);
                    command.Parameters.AddWithValue("@dateOfBirth",studentDateOfBirth);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
