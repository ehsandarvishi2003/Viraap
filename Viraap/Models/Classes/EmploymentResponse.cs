namespace Vira.Technical.Interview.Models.Classes
{
    public class EmploymentResponse
    {
        public string Status { get; set; }
        public string Result { get; set; }
        public EmploymentResponse()
        {
            Status = "OK";
            Result = "وضعیت استخدامی شما با موفقیت طی شده است";
        }
    }
}
