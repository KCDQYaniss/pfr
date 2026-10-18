namespace System.Text.Json.Serialization.Converters;

internal abstract class IEnumerableDefaultConverter`2 : JsonCollectionConverter
{

	internal virtual bool CanHaveMetadata
	{
		internal get { } //Length: 3
	}

	protected IEnumerableDefaultConverter`2() { }

	internal virtual bool get_CanHaveMetadata() { }

	protected virtual bool OnWriteResume(Utf8JsonWriter writer, TCollection value, JsonSerializerOptions options, ref WriteStack state) { }

}

