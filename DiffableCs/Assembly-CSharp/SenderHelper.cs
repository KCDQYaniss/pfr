//Type is in global namespace

public class SenderHelper
{
	internal enum EConnectionType
	{
		Default = 0,
		HttpConnection = 1,
	}

	internal sealed class SenderLogger : AbstractLogger
	{
		private static SenderLogger _instance; //Field offset: 0x0

		public static SenderLogger Instance
		{
			 get { } //Length: 311
		}

		private SenderLogger() { }

		public static SenderLogger get_Instance() { }

	}

	public const string SESSION_COOKIE_KEY = "PHPSESSID="; //Field offset: 0x0
	public const string FAILED_TO_RECEIVE_DATA = "Failed to receive data"; //Field offset: 0x0
	public static long NextRequestIndex; //Field offset: 0x0
	private static readonly UnityWebSender _unityWebSender; //Field offset: 0x8
	private static readonly HttpWebSender _httpWebSender; //Field offset: 0x10
	private static EConnectionType _currentSenderType; //Field offset: 0x18
	private static readonly Dictionary _senders; //Field offset: 0x20
	[CompilerGenerated]
	private static string <PhpSessionId>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private static string <AppVersion>k__BackingField; //Field offset: 0x30

	public static string AppVersion
	{
		[CompilerGenerated]
		 get { } //Length: 84
		[CompilerGenerated]
		 set { } //Length: 183
	}

	public static int EmptyResponseLimit
	{
		 get { } //Length: 6
	}

	public static TimeSpan EmptyResponseRepeatDelay
	{
		 get { } //Length: 137
	}

	public static SenderLogger Logger
	{
		 get { } //Length: 311
	}

	public static string PhpSessionId
	{
		[CompilerGenerated]
		 get { } //Length: 84
		[CompilerGenerated]
		 set { } //Length: 183
	}

	internal static ISender WebSender
	{
		internal get { } //Length: 124
	}

	private static SenderHelper() { }

	public SenderHelper() { }

	[CompilerGenerated]
	public static string get_AppVersion() { }

	public static int get_EmptyResponseLimit() { }

	public static TimeSpan get_EmptyResponseRepeatDelay() { }

	public static SenderLogger get_Logger() { }

	[CompilerGenerated]
	public static string get_PhpSessionId() { }

	internal static ISender get_WebSender() { }

	[CompilerGenerated]
	public static void set_AppVersion(string value) { }

	[CompilerGenerated]
	public static void set_PhpSessionId(string value) { }

	public static void SetSenderType(EConnectionType type) { }

}

