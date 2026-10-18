//Type is in global namespace

public class AIMapSettingsLogger : AbstractLogger
{
	private static AIMapSettingsLogger _instance; //Field offset: 0x0

	public static AIMapSettingsLogger Instance
	{
		 get { } //Length: 311
	}

	private AIMapSettingsLogger() { }

	public static AIMapSettingsLogger get_Instance() { }

	public bool IsDebugEnable() { }

	public bool IsTraceEnable() { }

	public void LogErrorEditor(string str) { }

}

