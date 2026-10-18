namespace System.Text.Json.Serialization.Converters;

internal sealed class ReadOnlyMemoryConverter`1 : JsonCollectionConverter
{

	internal virtual bool CanHaveMetadata
	{
		internal get { } //Length: 3
	}

	public virtual bool HandleNull
	{
		 get { } //Length: 3
	}

	public ReadOnlyMemoryConverter`1() { }

	internal virtual bool get_CanHaveMetadata() { }

	public virtual bool get_HandleNull() { }

	protected virtual bool OnWriteResume(Utf8JsonWriter writer, ReadOnlyMemory value, JsonSerializerOptions options, ref WriteStack state) { }

	internal static bool OnWriteResume(Utf8JsonWriter writer, ReadOnlySpan value, JsonSerializerOptions options, ref WriteStack state) { }

}

