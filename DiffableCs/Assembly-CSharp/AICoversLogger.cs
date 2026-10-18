//Type is in global namespace

public class AICoversLogger : AbstractLogger
{
	private static AICoversLogger _instance; //Field offset: 0x0

	public static AICoversLogger Instance
	{
		 get { } //Length: 311
	}

	private AICoversLogger() { }

	public static AICoversLogger get_Instance() { }

	public bool IsDebugEnable() { }

	public bool IsTraceEnable() { }

	public void LogErrorEditor(string str) { }

}

