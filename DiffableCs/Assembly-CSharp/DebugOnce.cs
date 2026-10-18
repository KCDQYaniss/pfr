//Type is in global namespace

public static class DebugOnce
{
	private static HashSet _logged; //Field offset: 0x0

	private static DebugOnce() { }

	public static void LogError(string message) { }

	public static void LogErrorFormat(string format, object[] args) { }

	public static void LogWarning(string message) { }

	public static void LogWarningFormat(string format, object[] args) { }

}

