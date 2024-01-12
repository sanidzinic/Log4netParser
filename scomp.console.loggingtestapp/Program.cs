using Microsoft.Extensions.Configuration;
using scomp.main.console.contracts;
using scomp.main.console.logparser.Helpers;

// Initialize Appsettings.json and Set BasePath
var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);
// Configuration
IConfiguration config = builder.Build();
// Initialize Parameters, Logfile and Regex-Patterns
string patternSplit = config.GetSection("Log4netRegexSplit").Value;
string sampleFile = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"log4net_examplefile.txt"));
string patternParse = config.GetSection("Log4netRegexParse").Value;
// Parse it!
Log4netParser parser = new Log4netParser(sampleFile,patternSplit,patternParse);
List<StructuredLogEntry> result = parser.GetStructuredResult();
int a = 0;
