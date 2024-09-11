namespace Vira.Technical.Interview.Models.Entites
{
    public class Employee
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Family { get; set; }
        public required int Code { get; set; }
    }
}
