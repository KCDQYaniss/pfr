namespace System.Text.Json.Serialization.Converters;

internal class StackOrQueueConverter`1 : JsonCollectionConverter
{

	internal virtual bool CanPopulate
	{
		internal get { } //Length: 3
	}

	public StackOrQueueConverter`1() { }

	internal virtual bool get_CanPopulate() { }

	protected virtual bool OnWriteResume(Utf8JsonWriter writer, TCollection value, JsonSerializerOptions options, ref WriteStack state) { }

}

