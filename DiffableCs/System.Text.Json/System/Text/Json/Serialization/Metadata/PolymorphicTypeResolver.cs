namespace System.Text.Json.Serialization.Metadata;

internal sealed class PolymorphicTypeResolver
{
	private sealed class DerivedJsonTypeInfo
	{
		private JsonTypeInfo _jsonTypeInfo; //Field offset: 0x10
		[CompilerGenerated]
		private readonly Type <DerivedType>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private readonly object <TypeDiscriminator>k__BackingField; //Field offset: 0x20

		public Type DerivedType
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public object TypeDiscriminator
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public DerivedJsonTypeInfo(Type type, object typeDiscriminator) { }

		[CompilerGenerated]
		public Type get_DerivedType() { }

		[CompilerGenerated]
		public object get_TypeDiscriminator() { }

		public JsonTypeInfo GetJsonTypeInfo(JsonSerializerOptions options) { }

	}

	private readonly ConcurrentDictionary _typeToDiscriminatorId; //Field offset: 0x10
	private readonly Dictionary _discriminatorIdtoType; //Field offset: 0x18
	private readonly JsonSerializerOptions _options; //Field offset: 0x20
	[CompilerGenerated]
	private readonly Type <BaseType>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly JsonUnknownDerivedTypeHandling <UnknownDerivedTypeHandling>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private readonly bool <UsesTypeDiscriminators>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private readonly bool <IgnoreUnrecognizedTypeDiscriminators>k__BackingField; //Field offset: 0x35
	[CompilerGenerated]
	private readonly string <TypeDiscriminatorPropertyName>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private readonly byte[] <TypeDiscriminatorPropertyNameUtf8>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private readonly Nullable <CustomTypeDiscriminatorPropertyNameJsonEncoded>k__BackingField; //Field offset: 0x48

	public Type BaseType
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public Nullable CustomTypeDiscriminatorPropertyNameJsonEncoded
	{
		[CompilerGenerated]
		 get { } //Length: 21
	}

	public byte[] TypeDiscriminatorPropertyNameUtf8
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public JsonUnknownDerivedTypeHandling UnknownDerivedTypeHandling
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public bool UsesTypeDiscriminators
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public PolymorphicTypeResolver(JsonSerializerOptions options, JsonPolymorphismOptions polymorphismOptions, Type baseType, bool converterCanHaveMetadata) { }

	[CompilerGenerated]
	internal static JsonTypeInfo <FindNearestPolymorphicBaseType>g__ResolveAncestorTypeInfo|30_0(Type type, JsonSerializerOptions options) { }

	[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2070:UnrecognizedReflectionPattern", Justification = "The call to GetInterfaces will cross-reference results with interface types already declared as derived types of the polymorphic base type.")]
	private DerivedJsonTypeInfo CalculateNearestAncestor(Type type) { }

	[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2075:UnrecognizedReflectionPattern", Justification = "The call to GetInterfaces will cross-reference results with interface types already declared as derived types of the polymorphic base type.")]
	internal static JsonTypeInfo FindNearestPolymorphicBaseType(JsonTypeInfo typeInfo) { }

	[CompilerGenerated]
	public Type get_BaseType() { }

	[CompilerGenerated]
	public Nullable get_CustomTypeDiscriminatorPropertyNameJsonEncoded() { }

	[CompilerGenerated]
	public byte[] get_TypeDiscriminatorPropertyNameUtf8() { }

	[CompilerGenerated]
	public JsonUnknownDerivedTypeHandling get_UnknownDerivedTypeHandling() { }

	[CompilerGenerated]
	public bool get_UsesTypeDiscriminators() { }

	public static bool IsSupportedDerivedType(Type baseType, Type derivedType) { }

	public static bool IsSupportedPolymorphicBaseType(Type type) { }

	public bool TryGetDerivedJsonTypeInfo(Type runtimeType, out JsonTypeInfo jsonTypeInfo, out object typeDiscriminator) { }

}

