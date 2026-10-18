namespace System.Text.Json.Serialization.Converters;

internal sealed class UnsupportedTypeConverter`1 : JsonConverter
{
	private readonly string _errorMessage; //Field offset: 0x0

	public string ErrorMessage
	{
		 get { } //Length: 300
	}

	public UnsupportedTypeConverter`1(string errorMessage = null) { }

	public string get_ErrorMessage() { }

	public virtual void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options) { }

}

