namespace AppForPractica.Models
{
    public class TItem
    {
        public string ItemType { get; set; }
        public int ItemId { get; set; }
        public int State { get; set; }
        public int ComputerId { get; set; }
        public int OwnerId { get; set; }
        public DateTime TimeStamp { get; set; }
        public int Rights { get; set; }
    }
}
