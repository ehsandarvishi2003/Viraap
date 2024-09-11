using System.ComponentModel.DataAnnotations;

namespace Vira.Technical.Interview.Models.Entites
{
    public class Customer
    {
        [Key]
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Family { get; set; }
        public required short Age { get; set; }
    }
}


