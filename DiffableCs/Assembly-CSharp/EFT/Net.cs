namespace EFT;

public abstract class Net
{
	internal class ExceptionWithStack : Exception
	{
		private string _localStackTrace; //Field offset: 0x90

		public virtual string StackTrace
		{
			 get { } //Length: 37
		}

		public ExceptionWithStack(string message) { }

		public virtual string get_StackTrace() { }

		public virtual string ToString() { }

	}

	[CompilerGenerated]
	private static NetworkConnection <Connection>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private static ENetLogsLevel <LogsLevel>k__BackingField; //Field offset: 0x8

	internal static NetworkConnection Connection
	{
		[CompilerGenerated]
		internal get { } //Length: 59
		[CompilerGenerated]
		internal set { } //Length: 151
	}

	public static ENetLogsLevel LogsLevel
	{
		[CompilerGenerated]
		 get { } //Length: 59
		[CompilerGenerated]
		 set { } //Length: 64
	}

	protected Net() { }

	[CompilerGenerated]
	internal static NetworkConnection get_Connection() { }

	[CompilerGenerated]
	public static ENetLogsLevel get_LogsLevel() { }

	[CompilerGenerated]
	internal static void set_Connection(NetworkConnection value) { }

	[CompilerGenerated]
	public static void set_LogsLevel(ENetLogsLevel value) { }

	public static void Trace(string message, string[] context) { }

	public static void Trace(byte tracerId, string message, string[] context) { }

	public static void Trace(ETraceCode code, string[] context) { }

	public static void Trace(byte tracerId, ETraceCode code, string[] context) { }

	public static void TraceError(string message, string[] context) { }

	public static void TraceError(byte tracerId, string message, string[] context) { }

	public static void TraceError(ETraceCode code, Exception e) { }

	public static void TraceError(ETraceCode code, string message, Exception e) { }

	public static void TraceError(ETraceCode code, string[] context) { }

	public static void TraceError(byte tracerId, ETraceCode code, string[] context) { }

}

