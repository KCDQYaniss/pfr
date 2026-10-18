//Type is in global namespace

public class AIMoveLogger : AbstractLogger
{
	private static AIMoveLogger _instance; //Field offset: 0x0

	public static AIMoveLogger Instance
	{
		 get { } //Length: 311
	}

	private AIMoveLogger() { }

	public static AIMoveLogger get_Instance() { }

	public bool IsDebugEnable() { }

	public bool IsTraceEnable() { }

	public void LogErrorEditor(string str) { }

}

