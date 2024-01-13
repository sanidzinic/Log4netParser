namespace sd.log4netparser.contracts
{
    public class StructuredLogEntry
    {
        public string Logger { get; set; }
        public DateTime Date { get; set; }
        public string Level { get; set; }
        public string Entry { get; set; }

    }
}
