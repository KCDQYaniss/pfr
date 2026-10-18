namespace System.Text.Json.Serialization.Converters;

internal sealed class SmallObjectWithParameterizedConstructorConverter`5 : ObjectWithParameterizedConstructorConverter
{

	public SmallObjectWithParameterizedConstructorConverter`5() { }

	[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
	[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
	internal virtual void ConfigureJsonTypeInfoUsingReflection(JsonTypeInfo jsonTypeInfo, JsonSerializerOptions options) { }

}

