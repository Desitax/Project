using DateBaseProject;
using Microsoft.Data.SqlClient;
SqlConnection stringConnection = new SqlConnection(@"Data Source=.;Integrated Security=True;
Trust Server Certificate=True; Initial Catalog=DataBaseProject;");

//string command = Console.ReadLine();
//while(command!="End")
//{

//}
//InsertRequests insertRequests = new InsertRequests();
//insertRequests.InsertSubjects(stringConnection);

InsertRequests insertRequests1 = new InsertRequests();
insertRequests1.InsertStudents(stringConnection);


