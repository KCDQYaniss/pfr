namespace EFT;

public sealed class DictionaryConverter : JsonConverter
{
	private sealed class EnumKeyAdapter`1 : IEnumKeyAdapter
	{

		public EnumKeyAdapter`1() { }

		public override object Parse(string propertyName) { }

		public override string Serialize(object key) { }

	}

	private interface IEnumKeyAdapter
	{

		public object Parse(string propertyName) { }

		public string Serialize(object key) { }

	}

	private static readonly Dictionary _enumKeyAdapters; //Field offset: 0x0
	private static readonly object _enumHelpersLock; //Field offset: 0x8

	private static DictionaryConverter() { }

	public DictionaryConverter() { }

	public virtual bool CanConvert(Type objectType) { }

	private static void EnsureEnumHelperInitialized(Type enumType) { }

	private static string GetEnumKeyName(Type keyType, object key) { }

	private static object GetEnumKeyValue(Type keyType, string propertyName) { }

	private static void PopulateEnumKeyDictionary(JsonReader reader, JsonSerializer serializer, IDictionary result, Type keyType, Type valueType) { }

	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	private static bool TryGetDictionaryArguments(Type objectType, out Type keyType, out Type valueType) { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

