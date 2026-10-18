namespace System.Text.Json.Serialization.Metadata;

[Extension]
[Nullable(0)]
[NullableContext(1)]
public static class JsonTypeInfoResolver
{
	[CompilerGenerated]
	private static readonly IJsonTypeInfoResolver <Empty>k__BackingField; //Field offset: 0x0

	internal static IJsonTypeInfoResolver Empty
	{
		[CompilerGenerated]
		internal get { } //Length: 83
	}

	private static JsonTypeInfoResolver() { }

	public static IJsonTypeInfoResolver Combine(IJsonTypeInfoResolver[] resolvers) { }

	[CompilerGenerated]
	internal static IJsonTypeInfoResolver get_Empty() { }

	[Extension]
	internal static bool IsCompatibleWithOptions(IJsonTypeInfoResolver resolver, JsonSerializerOptions options) { }

}

