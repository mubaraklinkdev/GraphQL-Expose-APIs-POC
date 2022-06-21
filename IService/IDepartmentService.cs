using GraphQL.Models;

namespace GraphQL.IService
{
    public interface IDepartmentService
    {
        List<Department> GetDepartments();
    }
}
