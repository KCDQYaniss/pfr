namespace System.Text.Json.Serialization.Converters;

internal sealed class ListOfTConverter`2 : IEnumerableDefaultConverter
{

	internal virtual bool CanPopulate
	{
		internal get { } //Length: 3
	}

	public ListOfTConverter`2() { }

	internal virtual bool get_CanPopulate() { }

	protected virtual bool OnWriteResume(Utf8JsonWriter writer, TCollection value, JsonSerializerOptions options, ref WriteStack state) { }

}

