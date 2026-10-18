namespace FlyingWormConsole3.LiteNetLib;

public static class NetDebug
{
	public static INetLogger Logger; //Field offset: 0x0
	private static readonly object DebugLogLock; //Field offset: 0x8

	private static NetDebug() { }

	[Conditional("DEBUG_MESSAGES")]
	internal static void Write(string str, object[] args) { }

	[Conditional("DEBUG_MESSAGES")]
	internal static void Write(NetLogLevel level, string str, object[] args) { }

	internal static void WriteError(string str, object[] args) { }

	[Conditional("DEBUG_MESSAGES")]
	[Conditional("DEBUG")]
	internal static void WriteForce(string str, object[] args) { }

	[Conditional("DEBUG_MESSAGES")]
	[Conditional("DEBUG")]
	internal static void WriteForce(NetLogLevel level, string str, object[] args) { }

	private static void WriteLogic(NetLogLevel logLevel, string str, object[] args) { }

}

