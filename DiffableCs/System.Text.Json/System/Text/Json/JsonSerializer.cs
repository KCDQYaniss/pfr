namespace System.Text.Json;

[Extension]
[Nullable(0)]
[NullableContext(1)]
public static class JsonSerializer
{
	[CompilerGenerated]
	private static readonly bool <IsReflectionEnabledByDefault>k__BackingField; //Field offset: 0x0
	private static readonly byte[] s_idPropertyName; //Field offset: 0x8
	private static readonly byte[] s_refPropertyName; //Field offset: 0x10
	private static readonly byte[] s_typePropertyName; //Field offset: 0x18
	private static readonly byte[] s_valuesPropertyName; //Field offset: 0x20
	internal static readonly JsonEncodedText s_metadataId; //Field offset: 0x28
	internal static readonly JsonEncodedText s_metadataRef; //Field offset: 0x38
	internal static readonly JsonEncodedText s_metadataType; //Field offset: 0x48
	internal static readonly JsonEncodedText s_metadataValues; //Field offset: 0x58

	public static bool IsReflectionEnabledByDefault
	{
		[CompilerGenerated]
		 get { } //Length: 83
	}

	private static JsonSerializer() { }

	[CompilerGenerated]
	public static bool get_IsReflectionEnabledByDefault() { }

	internal static MetadataPropertyName GetMetadataPropertyName(ReadOnlySpan propertyName, PolymorphicTypeResolver resolver) { }

	[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
	[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
	private static JsonTypeInfo GetTypeInfo(JsonSerializerOptions options) { }

	[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
	[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
	private static JsonTypeInfo GetTypeInfo(JsonSerializerOptions options, Type inputType) { }

	internal static bool IsValidCreationHandlingValue(JsonObjectCreationHandling handling) { }

	internal static bool IsValidNumberHandlingValue(JsonNumberHandling handling) { }

	internal static bool IsValidUnmappedMemberHandlingValue(JsonUnmappedMemberHandling handling) { }

	[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
	[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
	public static void Serialize(Utf8JsonWriter writer, object value, Type inputType, JsonSerializerOptions options = null) { }

	[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
	[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
	public static string Serialize(object value, Type inputType, JsonSerializerOptions options = null) { }

	[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
	[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
	public static void Serialize(Utf8JsonWriter writer, TValue value, JsonSerializerOptions options = null) { }

	internal static bool TryGetReferenceForValue(object currentValue, ref WriteStack state, Utf8JsonWriter writer) { }

	internal static T UnboxOnWrite(object value) { }

	private static void ValidateInputType(object value, Type inputType) { }

	internal static MetadataPropertyName WriteMetadataForCollection(JsonConverter jsonConverter, ref WriteStack state, Utf8JsonWriter writer) { }

	internal static MetadataPropertyName WriteMetadataForObject(JsonConverter jsonConverter, ref WriteStack state, Utf8JsonWriter writer) { }

	private static string WriteStringAsObject(object value, JsonTypeInfo jsonTypeInfo) { }

}

