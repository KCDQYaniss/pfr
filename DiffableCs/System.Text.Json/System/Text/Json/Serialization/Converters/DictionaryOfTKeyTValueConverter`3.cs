namespace System.Text.Json.Serialization.Converters;

internal sealed class DictionaryOfTKeyTValueConverter`3 : DictionaryDefaultConverter
{

	internal virtual bool CanPopulate
	{
		internal get { } //Length: 3
	}

	public DictionaryOfTKeyTValueConverter`3() { }

	internal virtual bool get_CanPopulate() { }

	protected private virtual bool OnWriteResume(Utf8JsonWriter writer, TCollection value, JsonSerializerOptions options, ref WriteStack state) { }

}

