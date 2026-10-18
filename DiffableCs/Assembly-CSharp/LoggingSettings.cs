//Type is in global namespace

public class LoggingSettings : ScriptableObject
{
	private static LoggingSettings _instance; //Field offset: 0x0
	public bool AILogging; //Field offset: 0x18

	public static LoggingSettings Instance
	{
		 get { } //Length: 217
	}

	public LoggingSettings() { }

	public static LoggingSettings get_Instance() { }

}

