namespace System.Text.Json.Serialization.Converters;

internal sealed class MemoryConverter`1 : JsonCollectionConverter
{

	internal virtual bool CanHaveMetadata
	{
		internal get { } //Length: 3
	}

	public virtual bool HandleNull
	{
		 get { } //Length: 3
	}

	public MemoryConverter`1() { }

	internal virtual bool get_CanHaveMetadata() { }

	public virtual bool get_HandleNull() { }

	protected virtual bool OnWriteResume(Utf8JsonWriter writer, Memory value, JsonSerializerOptions options, ref WriteStack state) { }

}

