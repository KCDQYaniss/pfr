//Type is in global namespace

public class LoggingRule
{
	public string fileName; //Field offset: 0x10
	public ELogLevel minLevel; //Field offset: 0x18

	[JsonIgnore]
	public LogLevel LogLevel
	{
		 get { } //Length: 4
	}

	public LoggingRule() { }

	public LogLevel get_LogLevel() { }

}

