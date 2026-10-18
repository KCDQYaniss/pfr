//Type is in global namespace

public static class EnumHelper`1
{
	private sealed class EnumComparer : IComparer
	{

		public EnumComparer() { }

		public override int Compare(T x, T y) { }

	}

	private sealed class EnumEqualityComparer : IEqualityComparer
	{

		public EnumEqualityComparer() { }

		public override bool Equals(T x, T y) { }

		public override int GetHashCode(T obj) { }

	}

	public static readonly Type Type; //Field offset: 0x0
	private static readonly Func _longConverter; //Field offset: 0x0
	private static readonly Func _intConverter; //Field offset: 0x0
	private static readonly Func _shortConverter; //Field offset: 0x0
	private static readonly Func _byteConverter; //Field offset: 0x0
	private static Dictionary _valueNameMap; //Field offset: 0x0
	private static Dictionary _nameValueMap; //Field offset: 0x0
	public static readonly int ByteLength; //Field offset: 0x0
	private static string[] _serializationNames; //Field offset: 0x0
	public static readonly IEqualityComparer EqualityComparer; //Field offset: 0x0
	public static readonly IComparer Comparer; //Field offset: 0x0
	public static readonly TypeCode TypeCode; //Field offset: 0x0
	public static readonly int Count; //Field offset: 0x0
	public static readonly ReadOnlyCollection Names; //Field offset: 0x0
	public static readonly ReadOnlyCollection Values; //Field offset: 0x0
	private static string[] _localizationKeys; //Field offset: 0x0
	private static readonly long _minValue; //Field offset: 0x0

	private static IReadOnlyDictionary NameToValueMap
	{
		private get { } //Length: 155
	}

	private static string[] SerializationNames
	{
		private get { } //Length: 155
	}

	private static IReadOnlyDictionary ValueToNameMap
	{
		private get { } //Length: 155
	}

	private static EnumHelper`1() { }

	[CompilerGenerated]
	internal static Func <.cctor>g__CompileLambda|17_0() { }

	public static void AddFlag(ref T currentFlags, T flagToAdd) { }

	public static T FromSerializationValue(long encryptedValue) { }

	private static IReadOnlyDictionary get_NameToValueMap() { }

	private static string[] get_SerializationNames() { }

	private static IReadOnlyDictionary get_ValueToNameMap() { }

	[CanBeNull]
	private static TAttribute GetAttributeOfValue(string name) { }

	public static byte GetByteFromValue(T value) { }

	public static Dictionary GetDictWith() { }

	public static int GetIntFromValue(T value) { }

	public static string GetJsonName(T value) { }

	public static string GetLocalizationKey(T value) { }

	public static IReadOnlyList GetLocalizedNames() { }

	public static long GetLongFromValue(T value) { }

	public static string GetName(T value) { }

	public static short GetShortFromValue(T value) { }

	public static T GetValue(int integer) { }

	public static bool HasFlag(T value, T flag) { }

	private static ArgumentException IncorrectTypeCodeException() { }

	public static int IndexOf(T value) { }

	private static void InitNameToValueMap() { }

	private static void InitValueToNameMap() { }

	public static bool IsDefined(T value) { }

	public static void RemoveFlag(ref T currentFlags, T flagToRemove) { }

	public static string SerializeValue(T value) { }

	public static long ToSerializationValue(T enumValue) { }

	public static bool TryDeserializeValue(string name, out T value) { }

	public static bool TryGetValueByName(string name, out T value) { }

}

