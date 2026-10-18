namespace Comfort.Logs;

public sealed class LogFactory4Unity : LogFactory, ILogFactory
{
	private sealed class  : ILog
	{

		public () { }

		private override void Comfort.Logs.ILog.Error(object message, Exception exception) { }

		private override void Comfort.Logs.ILog.ErrorFormat(string format, object[] messages) { }

		private override void Comfort.Logs.ILog.ErrorFormat(string format, object message0, object message1, object message2) { }

		private override void Comfort.Logs.ILog.ErrorFormat(string format, object message0, object message1) { }

		private override void Comfort.Logs.ILog.ErrorFormat(string format, object message) { }

		private override void Comfort.Logs.ILog.Fatal(object message, Exception exception) { }

		private override void Comfort.Logs.ILog.FatalFormat(string format, object[] messages) { }

		private override void Comfort.Logs.ILog.FatalFormat(string format, object message) { }

		private override void Comfort.Logs.ILog.FatalFormat(string format, object message0, object message1) { }

		private override void Comfort.Logs.ILog.FatalFormat(string format, object message0, object message1, object message2) { }

		private override void Comfort.Logs.ILog.Info(object message, Exception exception) { }

		private override void Comfort.Logs.ILog.InfoFormat(string format, object message0, object message1, object message2) { }

		private override void Comfort.Logs.ILog.InfoFormat(string format, object message0, object message1) { }

		private override void Comfort.Logs.ILog.InfoFormat(string format, object message) { }

		private override void Comfort.Logs.ILog.InfoFormat(string format, object[] messages) { }

		private override void Comfort.Logs.ILog.Warn(object message, Exception exception) { }

		private override void Comfort.Logs.ILog.WarnFormat(string format, object[] messages) { }

		private override void Comfort.Logs.ILog.WarnFormat(string format, object message0, object message1) { }

		private override void Comfort.Logs.ILog.WarnFormat(string format, object message) { }

		private override void Comfort.Logs.ILog.WarnFormat(string format, object message0, object message1, object message2) { }

		public override void Error(object message) { }

		public override void Fatal(object message) { }

		public override void Info(object message) { }

		public override void Warn(object message) { }

		private static string (object , Exception ) { }

		private static string (object , object ) { }

		private static string (object , object , object ) { }

		private static string (object , object , object , object ) { }

		private static string (object , object[] ) { }

	}

	private static readonly ILog ; //Field offset: 0x0

	private static LogFactory4Unity() { }

	public LogFactory4Unity() { }

	private override ILog Comfort.Logs.ILogFactory.CreateLog(Type type) { }

	private override ILog Comfort.Logs.ILogFactory.CreateLog(string name) { }

}

