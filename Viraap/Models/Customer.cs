namespace Viraap.Models
{
    public class Customer
    {
        public Guid ID { get; set; }
        public required string Name { get; set; }
        public required string Family { get; set; }
        public required string Status {  get; set; }
        public required string FullDes { get; set; }
    }
}
