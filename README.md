# sd.console.log4netlogparser
This console app (written in .NET 8) will allow you to parse existing log files stored locally in the filesystem and give you the chance to migrate your logs, for example, to a database.  
> [!IMPORTANT]
> This logfile-parser is based on the default appender for log4net, your logs should look like this to achieve a result without exceptions:
## Examples
2024-01-12 19:33:53,904 [1] DEBUG My.Program [(null)] - test  
2024-01-12 19:33:53,904 [1] DEBUG My.Program [(null)] - test  
  
For more examples, check out the log4net_examplefile.txt  
## Usage & Configuration
* You can customize the RegexSplit & RegexParse Patterns in the appsettings.json file. Currently it's based on the standard/official log4net LogFileAppender.  
* The entire logfile content is currently passed as text from my provided example (copied during build to the bin-folder) - you need to replace it with your own
###Basic Usage
Log4netParser parser = new Log4netParser(sampleFile,patternSplit,patternParse);
List<StructuredLogEntry> result = parser.GetStructuredResult();