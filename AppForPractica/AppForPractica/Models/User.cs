namespace AppForPractica.Models
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
        public string Company { get; set;}
        public int DepartamentId { get; set; }
        public string Departament { get; set;}
        public int PositionId { get; set; }
        public string Position { get; set; }
        public string TabNom { get; set; }
        public byte[] Photo { get; set; }
        public string Phone { get; set; }
        public string HomePhone { get; set; }
        public int AccessLevelId { get; set; }
        public Status Status { get; set; }
        public int ContactIdIndex {get;set;}
        public bool IsLockedDayCrossing { get; set; }
        public bool IsFreeShedule { get; set; }
        public string ExternalId { get; set; }
        public string IsInArchive { get; set; }
        public Sex Sex { get; set; }
        public string EmailList { get; set; }
        public DateTime ArchivingTimeStamp { get; set; }
        public bool IsInBlackList { get; set; }
        public string BlackListComment { get; set; }
        public bool IsDemissed { get; set; }
        public string DemissedComment { get; set; }
        public DateTime ChangeTime { get; set; }
        public string Itn { get; set; }

    }

    public enum Status
    {
        Владелец=1,
        Администратор = 2,
        ДежурныйОфицер,
        ДежурныйОператор,
        Хозорган,
        Служащий,
        ОператорБюроПропусков,
        Посетитель
    }

    public enum Sex
    {
        Мужской = 1,
        Женский = 2
    }
}
