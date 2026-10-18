namespace EFT;

public sealed class CommandLine
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static ConvertDelegate <>9__12_0; //Field offset: 0x8
		public static ConvertDelegate <>9__13_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal string <GetString>b__12_0(string stringValue) { }

		internal string <GetString>b__13_0(string stringValue) { }

	}

	[CompilerGenerated]
	private sealed class <>c__20`1
	{
		public static readonly <>c__20 <>9; //Field offset: 0x0
		public static ConvertDelegate <>9__20_0; //Field offset: 0x0

		private static <>c__20`1() { }

		public <>c__20`1() { }

		internal TEnum <GetEnum>b__20_0(string value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__21`1
	{
		public static readonly <>c__21 <>9; //Field offset: 0x0
		public static ConvertDelegate <>9__21_0; //Field offset: 0x0

		private static <>c__21`1() { }

		public <>c__21`1() { }

		internal TEnum <GetEnum>b__21_0(string value) { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static ConvertDelegate <0>__Parse; //Field offset: 0x0
		public static ConvertDelegate <1>__Parse; //Field offset: 0x8
		public static ConvertDelegate <2>__Parse; //Field offset: 0x10

	}

	private sealed class ConvertDelegate`1 : MulticastDelegate
	{

		public ConvertDelegate`1(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string stringValue, AsyncCallback callback, object object) { }

		public override T EndInvoke(IAsyncResult result) { }

		public override T Invoke(string stringValue) { }

	}

	[CompilerGenerated]
	private string <Value>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string[] <Values>k__BackingField; //Field offset: 0x18
	private Dictionary _args; //Field offset: 0x20

	public IReadOnlyDictionary ParsedArgs
	{
		 get { } //Length: 5
	}

	internal string Value
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	internal string[] Values
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public CommandLine() { }

	public static CommandLine Create() { }

	public IReadOnlyDictionary get_ParsedArgs() { }

	[CompilerGenerated]
	internal string get_Value() { }

	[CompilerGenerated]
	internal string[] get_Values() { }

	internal bool GetBool(string argumentName) { }

	internal bool GetBool(string argumentName, bool defaultValue) { }

	private T GetClass(string argumentName, ConvertDelegate convertDelegate, T defaultValue) { }

	private T GetClass(string argumentName, ConvertDelegate convertDelegate) { }

	internal TEnum GetEnum(string argumentName) { }

	internal TEnum GetEnum(string argumentName, TEnum defaultValue) { }

	internal int GetInt(string argumentName) { }

	internal int GetInt(string argumentName, int defaultValue) { }

	public string GetString(string argumentName) { }

	public string GetString(string argumentName, string defaultValue) { }

	private T GetStruct(string argumentName, ConvertDelegate convertDelegate, Nullable defaultValue = null) { }

	internal ushort GetUShort(string argumentName, ushort defaultValue) { }

	internal ushort GetUShort(string argumentName) { }

	[CompilerGenerated]
	private void set_Value(string value) { }

	[CompilerGenerated]
	private void set_Values(string[] value) { }

	private bool TryGetString(string argumentName, out string value) { }

}

