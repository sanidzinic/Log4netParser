using scomp.main.console.contracts;
using System.Text.RegularExpressions;

namespace scomp.main.console.logparser.Helpers
{
    public class Log4netParser
    {
        public string LogFile { get; set; }
        public string RegexPatternSplit { get; set; }
        public string RegexPatternParse { get; set; }

        public Log4netParser(string logfile, string regexPatternSplit, string regexPatternParse)
        {
            LogFile = logfile;
            RegexPatternSplit = regexPatternSplit;
            RegexPatternParse = regexPatternParse;
        }

        public List<StructuredLogEntry> GetStructuredResult()
        {
            List<StructuredLogEntry> resultList = new List<StructuredLogEntry> ();

            try { 
            List<string> ParsedLogItems = new List<string>();
            foreach (var Item in Regex.Split(LogFile, RegexPatternSplit))
            {
                if (Item.Trim() != string.Empty)
                    ParsedLogItems.Add(Item);
            }

            int n = 1;
            foreach (var Item in ParsedLogItems)
            {
                var matches = Regex.Matches(Item, RegexPatternParse, RegexOptions.Singleline);
                string entry = matches[0].Groups[13].Value;
                string date = matches[0].Groups[1].Value;
                string level = matches[0].Groups[5].Value;
                string logger = matches[0].Groups[7].Value;
                resultList.Add(new StructuredLogEntry { Date=DateTime.Parse(date), Level=level, Logger=logger,Entry=entry });
            }
            }catch(Exception e)
            {
                throw new InvalidOperationException("Error while parsing the logs: " + e.Message);
            }
            return resultList;
        }
    }
}
