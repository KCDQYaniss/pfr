namespace Comfort.Logs;

public interface ILog
{

	public void Error(object message, Exception exception) { }

	public void Error(object message) { }

	public void ErrorFormat(string format, object[] messages) { }

	public void ErrorFormat(string format, object message0, object message1, object message2) { }

	public void ErrorFormat(string format, object message0, object message1) { }

	public void ErrorFormat(string format, object message) { }

	public void Fatal(object message, Exception exception) { }

	public void Fatal(object message) { }

	public void FatalFormat(string format, object[] messages) { }

	public void FatalFormat(string format, object message0, object message1) { }

	public void FatalFormat(string format, object message) { }

	public void FatalFormat(string format, object message0, object message1, object message2) { }

	public void Info(object message) { }

	public void Info(object message, Exception exception) { }

	public void InfoFormat(string format, object[] messages) { }

	public void InfoFormat(string format, object message0, object message1, object message2) { }

	public void InfoFormat(string format, object message0, object message1) { }

	public void InfoFormat(string format, object message) { }

	public void Warn(object message, Exception exception) { }

	public void Warn(object message) { }

	public void WarnFormat(string format, object message0, object message1) { }

	public void WarnFormat(string format, object message) { }

	public void WarnFormat(string format, object message0, object message1, object message2) { }

	public void WarnFormat(string format, object[] messages) { }

}

