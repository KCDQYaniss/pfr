//Type is in global namespace

public class LogEventInfo
{
	[CompilerGenerated]
	private LogLevel <Level>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Message>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Exception <Exception>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private object[] <Parameters>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly IDictionary <Properties>k__BackingField; //Field offset: 0x30

	public Exception Exception
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public LogLevel Level
	{
		[CompilerGenerated]
		 get { } //Length: 164
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public string Message
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public object[] Parameters
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public IDictionary Properties
	{
		[CompilerGenerated]
		 get { } //Length: 76
	}

	public LogEventInfo(LogLevel level, string message) { }

	public LogEventInfo(LogLevel level, string message, Exception exception, object[] parameters) { }

	public void AddProperty(object key, object value) { }

	[CompilerGenerated]
	public Exception get_Exception() { }

	[CompilerGenerated]
	public LogLevel get_Level() { }

	[CompilerGenerated]
	public string get_Message() { }

	[CompilerGenerated]
	public object[] get_Parameters() { }

	[CompilerGenerated]
	public IDictionary get_Properties() { }

	[CompilerGenerated]
	public void set_Exception(Exception value) { }

	[CompilerGenerated]
	public void set_Level(LogLevel value) { }

	[CompilerGenerated]
	public void set_Message(string value) { }

	[CompilerGenerated]
	public void set_Parameters(object[] value) { }

}

