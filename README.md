# sd.console.log4netlogparser
This Console App will let you parse existing logfiles which are stored locally in your filesystem and give you the chance to migrate your logs e.g. to a database.  
[!IMPORTANT]
> This logfile-parser is based on the default appender for log4net, your logs should look like this to achieve a result without exceptions:
## Examples
2024-01-12 19:33:53,904 [1] DEBUG My.Program [(null)] - test  
2024-01-12 19:33:53,904 [1] DEBUG My.Program [(null)] - test  
  
For more examples, check out the log4net_examplefile.txt