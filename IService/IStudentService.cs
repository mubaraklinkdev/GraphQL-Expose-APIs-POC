using GraphQL.Models;

namespace GraphQL.IService
{
    public interface IStudentService
    {
        List<Student> GetStudents();
    }
}
