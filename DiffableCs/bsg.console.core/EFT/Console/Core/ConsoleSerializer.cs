namespace EFT.Console.Core;

public class ConsoleSerializer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__28_0; //Field offset: 0x8
		public static Func <>9__29_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal string <ParseArray>b__29_0(string s) { }

		internal bool <ParseEnum>b__28_0(char c) { }

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass15_0
	{
		public StringBuilder buffer; //Field offset: 0x0
		public List result; //Field offset: 0x8

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static ArgumentDeserializer <0>__ParseByte; //Field offset: 0x0
		public static ArgumentDeserializer <1>__ParseInt; //Field offset: 0x8
		public static ArgumentDeserializer <2>__ParseFloat; //Field offset: 0x10
		public static ArgumentDeserializer <3>__ParseString; //Field offset: 0x18
		public static ArgumentDeserializer <4>__ParseVector2; //Field offset: 0x20
		public static ArgumentDeserializer <5>__ParseVector3; //Field offset: 0x28
		public static ArgumentDeserializer <6>__ParseBool; //Field offset: 0x30
		public static ArgumentSerializer <7>__SerializeFloat; //Field offset: 0x38
		public static ArgumentSerializer <8>__SerializeVector2; //Field offset: 0x40
		public static ArgumentSerializer <9>__SerializeVector3; //Field offset: 0x48
		public static ArgumentSerializer <10>__SerializeBool; //Field offset: 0x50
		public static ArgumentSerializer <11>__SerializeSimple; //Field offset: 0x58

	}

	public static readonly char SEPARATOR; //Field offset: 0x0
	public static readonly char COMMAND_NAME_SEPARATOR; //Field offset: 0x2
	public static readonly char COMMANDS_SEPARATOR; //Field offset: 0x4
	private static readonly char[] BRACKETS_OPEN_CHARS; //Field offset: 0x8
	private static readonly char[] BRACKETS_CLOSE_CHARS; //Field offset: 0x10
	private static readonly Type STRING_TYPE; //Field offset: 0x18
	private Dictionary _deserializers; //Field offset: 0x10
	private Dictionary _serializers; //Field offset: 0x18
	private ArgumentSerializer _defaultSerializer; //Field offset: 0x20

	private static ConsoleSerializer() { }

	public ConsoleSerializer() { }

	[CompilerGenerated]
	internal static bool <TokenSource>g__AddBuffer|15_0(bool denyPostProcessing, ref <>c__DisplayClass15_0 unnamed_param_1) { }

	public object Deserialize(string source, Type targetType) { }

	public T Deserialize(string source) { }

	public static string FormatCommandInput(string commandFullName, IEnumerable arguments) { }

	public string GetDefaultValueForType(Type t) { }

	private static bool IsDigitLike(string s) { }

	private static object ParseArray(string source, Type target, ArgumentDeserializer parser) { }

	private static object ParseBool(string source) { }

	private static object ParseByte(string source) { }

	private static object ParseEnum(string source, Type target) { }

	private static object ParseFloat(string source) { }

	private static float ParseFloatUnivercal(string f) { }

	private static object ParseInt(string source) { }

	private static object ParseString(string source) { }

	private static object ParseVector2(string source) { }

	private static object ParseVector3(string source) { }

	public void RegisterTypeConverter(Type t, ArgumentDeserializer deserializer, ArgumentSerializer serializer) { }

	public string Serialize(object source) { }

	private static string SerializeBool(object source) { }

	private static string SerializeFloat(object source) { }

	private static string SerializeSimple(object source) { }

	private static string SerializeVector2(object source) { }

	private static string SerializeVector3(object source) { }

	public string[] TokenSource(string source) { }

	public bool TryDeserialize(string source, out T result) { }

}

