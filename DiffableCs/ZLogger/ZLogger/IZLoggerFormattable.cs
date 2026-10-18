namespace ZLogger;

[NullableContext(1)]
public interface IZLoggerFormattable : IZLoggerEntryCreatable
{

	public bool IsSupportUtf8ParameterKey
	{
		 get { } //Length: 0
	}

	public int ParameterCount
	{
		 get { } //Length: 0
	}

	public bool get_IsSupportUtf8ParameterKey() { }

	public int get_ParameterCount() { }

	public string GetOriginalFormat() { }

	[NullableContext(0)]
	public ReadOnlySpan GetParameterKey(int index) { }

	public string GetParameterKeyAsString(int index) { }

	public Type GetParameterType(int index) { }

	[NullableContext(2)]
	public object GetParameterValue(int index) { }

	[NullableContext(2)]
	public T GetParameterValue(int index) { }

	public string ToString() { }

	public void ToString(IBufferWriter writer) { }

	public void WriteJsonParameterKeyValues(Utf8JsonWriter jsonWriter, JsonSerializerOptions jsonSerializerOptions, IKeyNameMutator keyNameMutator = null) { }

	public void WriteOriginalFormat(IBufferWriter writer) { }

}

