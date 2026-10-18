namespace System.Text.Json.Serialization.Converters;

internal sealed class IAsyncEnumerableOfTConverter`2 : JsonCollectionConverter
{

	internal virtual bool SupportsCreateObjectDelegate
	{
		internal get { } //Length: 3
	}

	public IAsyncEnumerableOfTConverter`2() { }

	internal virtual bool get_SupportsCreateObjectDelegate() { }

	internal virtual bool OnTryWrite(Utf8JsonWriter writer, TAsyncEnumerable value, JsonSerializerOptions options, ref WriteStack state) { }

	protected virtual bool OnWriteResume(Utf8JsonWriter writer, TAsyncEnumerable value, JsonSerializerOptions options, ref WriteStack state) { }

}

