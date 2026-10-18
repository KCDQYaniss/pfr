//Type is in global namespace

public class AILogger : AbstractLogger
{
	private static AILogger _instance; //Field offset: 0x0

	public static AILogger Instance
	{
		 get { } //Length: 311
	}

	private AILogger() { }

	public static AILogger get_Instance() { }

	public bool IsTraceEnable() { }

	public void LogCalculatePath(Vector3 from, Vector3 to, NavMeshPathStatus status, int length) { }

	public void LogCalculatePathFail(Vector3 from, Vector3 to) { }

	public void LogErrorEditor(string str) { }

}

