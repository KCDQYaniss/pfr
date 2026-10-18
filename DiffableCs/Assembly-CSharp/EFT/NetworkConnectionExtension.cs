namespace EFT;

[Extension]
internal static class NetworkConnectionExtension
{
	[CompilerGenerated]
	private static class <>O
	{
		public static LogDelegate <0>__LogErrorFormat; //Field offset: 0x0
		public static LogDelegate <1>__LogFormat; //Field offset: 0x8

	}

	private sealed class LogDelegate : MulticastDelegate
	{

		public LogDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string format, object[] args, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string format, object[] args) { }

	}

	[CompilerGenerated]
	private static AbstractLogger <Logger>k__BackingField; //Field offset: 0x0

	internal static AbstractLogger Logger
	{
		[CompilerGenerated]
		internal get { } //Length: 59
		[CompilerGenerated]
		internal set { } //Length: 151
	}

	[Extension]
	internal static void Close(NetworkConnection connection, string reason, bool isError) { }

	[Extension]
	public static int ConnectionId(long transportId) { }

	[CompilerGenerated]
	internal static AbstractLogger get_Logger() { }

	[Extension]
	public static int HostId(long transportId) { }

	[CompilerGenerated]
	internal static void set_Logger(AbstractLogger value) { }

	[Extension]
	internal static long TransportId(NetworkConnection connection) { }

}

