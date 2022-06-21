namespace GraphQL.Models
{
    public class Department
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public List<Student>? Students { get; set; }
    }
}
