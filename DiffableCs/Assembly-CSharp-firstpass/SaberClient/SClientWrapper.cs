namespace SaberClient;

public static class SClientWrapper
{
	internal sealed class LogDelegate : MulticastDelegate
	{

		public LogDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(LogLevel logLevel, string format, object[] args, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(LogLevel logLevel, string format, object[] args) { }

	}


	public static void CacheStaticData() { }

	public static void Load(LogDelegate logDelegate, byte[] sessionId, string serverIp, ushort antiCheatPort) { }

	public static void Unload() { }

}

