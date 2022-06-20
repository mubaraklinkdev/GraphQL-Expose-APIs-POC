using GraphQL.IService;
using GraphQL.Models;

namespace GraphQL.Services
{
    public class StudentService : IStudentService
    {
        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();

            for (int i = 0; i < 50; i++)
            {
                students.Add(new Student() 
                {
                    Age = i+5,
                    ID = i+1,
                    Name = "Student " + i+1
                
                });
            }

            return students;
        }
    }
}
