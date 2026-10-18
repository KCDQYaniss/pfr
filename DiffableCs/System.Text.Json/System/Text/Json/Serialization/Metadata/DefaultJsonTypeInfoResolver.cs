namespace System.Text.Json.Serialization.Metadata;

[Nullable(0)]
[NullableContext(1)]
public class DefaultJsonTypeInfoResolver : IJsonTypeInfoResolver, IBuiltInJsonTypeInfoResolver
{
	[CompilerGenerated]
	private struct <>c__DisplayClass3_0
	{
		public Dictionary converters; //Field offset: 0x0

	}

	private sealed class ModifierCollection : ConfigurationList
	{
		private readonly DefaultJsonTypeInfoResolver _resolver; //Field offset: 0x18

		public virtual bool IsReadOnly
		{
			 get { } //Length: 30
		}

		public virtual bool get_IsReadOnly() { }

		protected virtual void OnCollectionModifying() { }

	}

	private static Dictionary s_defaultSimpleConverters; //Field offset: 0x0
	private static JsonConverterFactory[] s_defaultFactoryConverters; //Field offset: 0x8
	private static MemberAccessor s_memberAccessor; //Field offset: 0x10
	private static DefaultJsonTypeInfoResolver s_defaultInstance; //Field offset: 0x18
	private bool _mutable; //Field offset: 0x10
	private ModifierCollection _modifiers; //Field offset: 0x18

	internal static MemberAccessor MemberAccessor
	{
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		internal get { } //Length: 201
	}

	[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
	[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
	private DefaultJsonTypeInfoResolver(bool mutable) { }

	[CompilerGenerated]
	internal static void <GetDefaultSimpleConverters>g__Add|3_0(JsonConverter converter, ref <>c__DisplayClass3_0 unnamed_param_1) { }

	[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
	[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
	private static void AddMember(JsonTypeInfo typeInfo, Type typeToConvert, MemberInfo memberInfo, bool shouldCheckForRequiredKeyword, bool hasJsonIncludeAttribute, ref PropertyHierarchyResolutionState state) { }

	[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
	[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
	private static void AddMembersDeclaredBySuperType(JsonTypeInfo typeInfo, Type currentType, bool constructorHasSetsRequiredMembersAttribute, ref PropertyHierarchyResolutionState state) { }

	[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
	[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
	private static JsonTypeInfo CreateJsonTypeInfo(Type type, JsonSerializerOptions options) { }

	[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
	[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
	private static JsonPropertyInfo CreatePropertyInfo(JsonTypeInfo typeInfo, Type typeToConvert, MemberInfo memberInfo, JsonSerializerOptions options, bool shouldCheckForRequiredKeyword, bool hasJsonIncludeAttribute) { }

	[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
	[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
	private static JsonTypeInfo CreateTypeInfoCore(Type type, JsonConverter converter, JsonSerializerOptions options) { }

	[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
	[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
	private static Func DetermineCreateObjectDelegate(Type type, JsonConverter converter) { }

	[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
	[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
	internal static void DeterminePropertyAccessors(JsonPropertyInfo jsonPropertyInfo, MemberInfo memberInfo, bool useNonPublicAccessors) { }

	private static void DeterminePropertyIsRequired(JsonPropertyInfo propertyInfo, MemberInfo memberInfo, bool shouldCheckForRequiredKeyword) { }

	private static void DeterminePropertyName(JsonPropertyInfo propertyInfo, MemberInfo memberInfo) { }

	private static void DeterminePropertyPolicies(JsonPropertyInfo propertyInfo, MemberInfo memberInfo) { }

	[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
	internal static MemberAccessor get_MemberAccessor() { }

	private static JsonConverter GetBuiltInConverter(Type typeToConvert) { }

	[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
	[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
	internal static JsonConverter GetConverterForType(Type typeToConvert, JsonSerializerOptions options, bool resolveJsonConverterAttribute = true) { }

	[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
	[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
	private static JsonConverter GetConverterFromAttribute(JsonConverterAttribute converterAttribute, Type typeToConvert, MemberInfo memberInfo, JsonSerializerOptions options) { }

	[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
	[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
	private static JsonConverter GetCustomConverterForMember(Type typeToConvert, MemberInfo memberInfo, JsonSerializerOptions options) { }

	[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
	[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
	private static JsonConverterFactory[] GetDefaultFactoryConverters() { }

	private static Dictionary GetDefaultSimpleConverters() { }

	private static Nullable GetNumberHandlingForType(Type type) { }

	private static Nullable GetObjectCreationHandlingForType(Type type) { }

	[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:RequiresUnreferencedCode", Justification = "The ctor is marked RequiresUnreferencedCode.")]
	[UnconditionalSuppressMessage("AotAnalysis", "IL3050:RequiresDynamicCode", Justification = "The ctor is marked RequiresDynamicCode.")]
	public override JsonTypeInfo GetTypeInfo(Type type, JsonSerializerOptions options) { }

	private static Nullable GetUnmappedMemberHandling(Type type) { }

	private static void PopulateParameterInfoValues(JsonTypeInfo typeInfo) { }

	[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
	[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
	private static void PopulateProperties(JsonTypeInfo typeInfo) { }

	[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
	[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
	private static void PopulatePropertyInfo(JsonPropertyInfo jsonPropertyInfo, MemberInfo memberInfo, JsonConverter customConverter, Nullable ignoreCondition, bool shouldCheckForRequiredKeyword, bool hasJsonIncludeAttribute) { }

	private static bool PropertyIsOverriddenAndIgnored(PropertyInfo propertyInfo, Dictionary ignoredMembers) { }

	[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
	[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
	internal static DefaultJsonTypeInfoResolver RootDefaultInstance() { }

	private override bool System.Text.Json.Serialization.Metadata.IBuiltInJsonTypeInfoResolver.IsCompatibleWithOptions(JsonSerializerOptions _) { }

	internal static bool TryGetDefaultSimpleConverter(Type typeToConvert, out JsonConverter converter) { }

}

