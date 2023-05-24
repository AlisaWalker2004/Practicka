namespace AppForPractica.Models
{
    public class TAccessLevel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TAccessLevelItem[] Items { get; set; }
    }
}
