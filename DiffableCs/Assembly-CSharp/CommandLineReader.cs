//Type is in global namespace

public class CommandLineReader
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static ConvertDelegate <>9__7_0; //Field offset: 0x8
		public static ConvertDelegate <>9__8_0; //Field offset: 0x10
		public static Func <>9__20_0; //Field offset: 0x18
		public static Func <>9__20_1; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal string <GetString>b__7_0(string stringValue) { }

		internal string <GetString>b__8_0(string stringValue) { }

		internal bool <ReloadCustomArguments>b__20_0(string str) { }

		internal bool <ReloadCustomArguments>b__20_1(string row) { }

	}

	[CompilerGenerated]
	private sealed class <>c__13`1
	{
		public static readonly <>c__13 <>9; //Field offset: 0x0
		public static ConvertDelegate <>9__13_0; //Field offset: 0x0

		private static <>c__13`1() { }

		public <>c__13`1() { }

		internal TEnum <GetEnum>b__13_0(string value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__14`1
	{
		public static readonly <>c__14 <>9; //Field offset: 0x0
		public static ConvertDelegate <>9__14_0; //Field offset: 0x0

		private static <>c__14`1() { }

		public <>c__14`1() { }

		internal TEnum <GetEnum>b__14_0(string value) { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static ConvertDelegate <0>__Parse; //Field offset: 0x0
		public static ConvertDelegate <1>__Parse; //Field offset: 0x8

	}

	private sealed class ConvertDelegate`1 : MulticastDelegate
	{

		public ConvertDelegate`1(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string stringValue, AsyncCallback callback, object object) { }

		public override T EndInvoke(IAsyncResult result) { }

		public override T Invoke(string stringValue) { }

	}

	private const string CUSTOM_ARGS_PREFIX = "-CustomArgs:"; //Field offset: 0x0
	private static readonly char[] _customArgsSeparators; //Field offset: 0x0
	[CompilerGenerated]
	private static readonly Dictionary <CustomArguments>k__BackingField; //Field offset: 0x8

	public static Dictionary CustomArguments
	{
		[CompilerGenerated]
		 get { } //Length: 84
	}

	private static CommandLineReader() { }

	public CommandLineReader() { }

	[CompilerGenerated]
	public static Dictionary get_CustomArguments() { }

	public static bool GetBool(string argumentName) { }

	public static bool GetBool(string argumentName, bool defaultValue) { }

	private static T GetClass(string argumentName, ConvertDelegate convertDelegate, T defaultValue) { }

	private static T GetClass(string argumentName, ConvertDelegate convertDelegate) { }

	public static string GetCommandLine() { }

	public static string[] GetCommandLineArgs() { }

	public static TEnum GetEnum(string argumentName) { }

	public static TEnum GetEnum(string argumentName, TEnum defaultValue) { }

	public static int GetInt(string argumentName) { }

	public static int GetInt(string argumentName, int defaultValue) { }

	public static string GetString(string argumentName) { }

	public static string GetString(string argumentName, string defaultValue) { }

	private static T GetStruct(string argumentName, ConvertDelegate convertDelegate, Nullable defaultValue = null) { }

	private static Dictionary ReloadCustomArguments() { }

	private static bool TryGetString(string argumentName, out string value) { }

}

