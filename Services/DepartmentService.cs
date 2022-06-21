using GraphQL.IService;
using GraphQL.Models;

namespace GraphQL.Services
{
    public class DepartmentService : IDepartmentService
    {
        public List<Department> GetDepartments()
        {
            List<Department> Departments = new List<Department>();

            for (int i = 0; i < 3; i++)
            {
                Departments.Add(new Department()
                {
                    Students = new List<Student>() {
                        new Student(){ ID=i,Name ="Ahmed",Age = i+5},
                        new Student(){ ID=i,Name ="Hassan",Age = i+5},
                    },
                    ID = i + 1,
                    Name = "Department " + i + 1

                });
            }

            return Departments;
        }
    }
}
