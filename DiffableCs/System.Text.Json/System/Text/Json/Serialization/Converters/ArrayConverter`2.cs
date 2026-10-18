namespace System.Text.Json.Serialization.Converters;

internal sealed class ArrayConverter`2 : IEnumerableDefaultConverter
{

	internal virtual bool CanHaveMetadata
	{
		internal get { } //Length: 3
	}

	internal virtual bool SupportsCreateObjectDelegate
	{
		internal get { } //Length: 3
	}

	public ArrayConverter`2() { }

	internal virtual bool get_CanHaveMetadata() { }

	internal virtual bool get_SupportsCreateObjectDelegate() { }

	protected virtual bool OnWriteResume(Utf8JsonWriter writer, TElement[] array, JsonSerializerOptions options, ref WriteStack state) { }

}

