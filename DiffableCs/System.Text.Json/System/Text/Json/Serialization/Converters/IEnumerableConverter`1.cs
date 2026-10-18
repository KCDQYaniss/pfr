namespace System.Text.Json.Serialization.Converters;

internal sealed class IEnumerableConverter`1 : JsonCollectionConverter
{
	private readonly bool _isDeserializable; //Field offset: 0x0

	internal virtual bool SupportsCreateObjectDelegate
	{
		internal get { } //Length: 3
	}

	public IEnumerableConverter`1() { }

	internal virtual bool get_SupportsCreateObjectDelegate() { }

	protected virtual bool OnWriteResume(Utf8JsonWriter writer, TCollection value, JsonSerializerOptions options, ref WriteStack state) { }

}

