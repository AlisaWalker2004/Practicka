namespace WebApplication1.Models
{
    public class User
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public int CompanyId { get; set; }
        public int DepartamentId { get; set; }
        public int PositionId { get; set; }
        public string Phone { get; set; }
        public Sex Sex { get; set; }
        public string EmailList { get; set; }
    }

    public enum Sex
    {
        Мужской = 1,
        Женский = 2
    }
}
