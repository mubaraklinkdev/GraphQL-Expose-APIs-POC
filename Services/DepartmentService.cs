using GraphQL.IService;
using GraphQL.Models;

namespace GraphQL.Services
{
    public class DepartmentService : IDepartmentService
    {
        public List<Department> GetDepartments()
        {
            List<Department> Departments = new List<Department>();

            for (int i = 0; i < 5; i++)
            {
                Departments.Add(new Department()
                {
                    Students = new List<Student>() {
                        new Student(){ ID=i,Name ="Ahmed",Age = i+5},
                        new Student(){ ID=i,Name ="Hassan",Age = i+6},
                    },
                    ID = i + 2,
                    Name = "D " + i + 2

                });
            }

            return Departments;
        }
    }
}
