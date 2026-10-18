namespace UnityEngine;

public interface ILogger : ILogHandler
{

	public bool logEnabled
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public ILogHandler logHandler
	{
		 get { } //Length: 0
	}

	public bool get_logEnabled() { }

	public ILogHandler get_logHandler() { }

	public bool IsLogTypeAllowed(LogType logType) { }

	public void Log(LogType logType, object message) { }

	public void Log(LogType logType, object message, Object context) { }

	public void LogError(string tag, object message) { }

	public void LogFormat(LogType logType, string format, object[] args) { }

	public void set_logEnabled(bool value) { }

}

