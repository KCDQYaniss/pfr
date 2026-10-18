namespace System.Text.Json;

internal sealed class JsonCamelCaseNamingPolicy : JsonNamingPolicy
{

	public JsonCamelCaseNamingPolicy() { }

	public virtual string ConvertName(string name) { }

	private static void FixCasing(Span chars) { }

}

