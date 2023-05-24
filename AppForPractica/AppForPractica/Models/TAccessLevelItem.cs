namespace AppForPractica.Models
{
    public class TAccessLevelItem
    {
        public int Id { get; set; }
        public string ItemType { get; set; }
        public int ItemId { get; set; }
        public int Rights { get; set; }
        public int TimeWindowId { get; set; }
        public int Antipassback { get;set; }
        public int LockTime { get; set; }
        public bool IsZoneAntipassback { get; set; }
        public int DoubleConfirmationId { get; set; }
        public int TripleConfirmationId { get; set; }
        public bool IsConfirming { get; set; }
        public bool IsConfirmationButton { get; set; }
    }

    public enum Antipassback
    {
        Нет=0,
        Строгий =1,
        Временной = 2,
        Мягкий
    }
}
