namespace AppForPractica.Models
{
    public class TKeyData
    {
        public int Id { get; set; }
        public CodeType CodeType { get; set; }
        public string Code { get; set; }
        public int AdditionalCodeType { get; set; }
        public string AdditioanalCode { get; set; }
        public int PersonId { get; set; }
        public int AccessLevelId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsBlocked { get; set; }
        public bool IsStoreinDevice { get; set; }
        public bool IsInStopList { get; set; }
        public string Comment { get; set; }
    }

    public enum CodeType
    {
        ПарольДляПрограмм = 1,
        ПинКод=2,
        БрелокTochMemory,
        ProxyКарта,
        АвтомобильныйНомер,
        ОтпечатокПальца,
        ОтпечатокЛица,
        ОтпечатокЛадони,
        ПинКод2,
        ОтпечатокЛицаS1007
    }
}
