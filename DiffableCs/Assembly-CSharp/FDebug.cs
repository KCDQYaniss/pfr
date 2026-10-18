//Type is in global namespace

public static class FDebug
{
	private class Logger : AbstractLogger
	{

		public Logger(string name) { }

	}

	private static Dictionary _loggers; //Field offset: 0x0

	private static FDebug() { }

	private static void AddLogger(string name) { }

	private static Logger GetLogger(string name) { }

	public static void Log(string name, string message) { }

}

