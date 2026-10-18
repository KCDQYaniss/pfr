namespace System.Text.Json.Serialization;

[Nullable(0)]
[NullableContext(2)]
public abstract class JsonConverter
{
	private ConverterStrategy _converterStrategy; //Field offset: 0x10
	[CompilerGenerated]
	private bool <CanUseDirectReadOrWrite>k__BackingField; //Field offset: 0x11
	[CompilerGenerated]
	private bool <CanBePolymorphic>k__BackingField; //Field offset: 0x12
	[CompilerGenerated]
	private bool <RequiresReadAhead>k__BackingField; //Field offset: 0x13
	[CompilerGenerated]
	private bool <UsesDefaultHandleNull>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private readonly bool <HandleNullOnRead>k__BackingField; //Field offset: 0x15
	[CompilerGenerated]
	private readonly bool <HandleNullOnWrite>k__BackingField; //Field offset: 0x16
	[CompilerGenerated]
	private readonly bool <IsValueType>k__BackingField; //Field offset: 0x17
	[CompilerGenerated]
	private readonly bool <IsInternalConverter>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly bool <IsInternalConverterForNumberType>k__BackingField; //Field offset: 0x19
	[CompilerGenerated]
	private readonly bool <ConstructorIsParameterized>k__BackingField; //Field offset: 0x1A
	[CompilerGenerated]
	private ConstructorInfo <ConstructorInfo>k__BackingField; //Field offset: 0x20

	internal bool CanBePolymorphic
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	internal override bool CanHaveMetadata
	{
		internal get { } //Length: 3
	}

	internal override bool CanPopulate
	{
		internal get { } //Length: 3
	}

	internal bool CanUseDirectReadOrWrite
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	internal ConstructorInfo ConstructorInfo
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 82
	}

	internal override bool ConstructorIsParameterized
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	internal ConverterStrategy ConverterStrategy
	{
		internal get { } //Length: 5
		internal set { } //Length: 52
	}

	internal abstract Type ElementType
	{
		internal get { } //Length: 0
	}

	internal bool HandleNullOnRead
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	internal bool HandleNullOnWrite
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	internal bool IsInternalConverter
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	internal bool IsInternalConverterForNumberType
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	internal bool IsValueType
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	internal abstract Type KeyType
	{
		internal get { } //Length: 0
	}

	internal bool RequiresReadAhead
	{
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	internal override JsonConverter SourceConverterForCastingConverter
	{
		internal get { } //Length: 3
	}

	internal override bool SupportsCreateObjectDelegate
	{
		internal get { } //Length: 3
	}

	public abstract Type Type
	{
		 get { } //Length: 0
	}

	internal bool UsesDefaultHandleNull
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	internal JsonConverter() { }

	[NullableContext(1)]
	public abstract bool CanConvert(Type typeToConvert) { }

	internal override void ConfigureJsonTypeInfo(JsonTypeInfo jsonTypeInfo, JsonSerializerOptions options) { }

	[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
	[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
	internal override void ConfigureJsonTypeInfoUsingReflection(JsonTypeInfo jsonTypeInfo, JsonSerializerOptions options) { }

	internal JsonConverter CreateCastingConverter() { }

	internal override JsonTypeInfo CreateJsonTypeInfo(JsonSerializerOptions options) { }

	[CompilerGenerated]
	internal bool get_CanBePolymorphic() { }

	internal override bool get_CanHaveMetadata() { }

	internal override bool get_CanPopulate() { }

	[CompilerGenerated]
	internal bool get_CanUseDirectReadOrWrite() { }

	[CompilerGenerated]
	internal ConstructorInfo get_ConstructorInfo() { }

	[CompilerGenerated]
	internal override bool get_ConstructorIsParameterized() { }

	internal ConverterStrategy get_ConverterStrategy() { }

	internal abstract Type get_ElementType() { }

	[CompilerGenerated]
	internal bool get_HandleNullOnRead() { }

	[CompilerGenerated]
	internal bool get_HandleNullOnWrite() { }

	[CompilerGenerated]
	internal bool get_IsInternalConverter() { }

	[CompilerGenerated]
	internal bool get_IsInternalConverterForNumberType() { }

	[CompilerGenerated]
	internal bool get_IsValueType() { }

	internal abstract Type get_KeyType() { }

	internal override JsonConverter get_SourceConverterForCastingConverter() { }

	internal override bool get_SupportsCreateObjectDelegate() { }

	public abstract Type get_Type() { }

	[CompilerGenerated]
	internal bool get_UsesDefaultHandleNull() { }

	abstract ConverterStrategy GetDefaultConverterStrategy() { }

	internal abstract bool OnTryWriteAsObject(Utf8JsonWriter writer, object value, JsonSerializerOptions options, ref WriteStack state) { }

	internal JsonConverter ResolvePolymorphicConverter(object value, JsonTypeInfo jsonTypeInfo, JsonSerializerOptions options, ref WriteStack state) { }

	[CompilerGenerated]
	internal void set_CanBePolymorphic(bool value) { }

	[CompilerGenerated]
	internal void set_CanUseDirectReadOrWrite(bool value) { }

	[CompilerGenerated]
	internal void set_ConstructorInfo(ConstructorInfo value) { }

	internal void set_ConverterStrategy(ConverterStrategy value) { }

	[CompilerGenerated]
	 void set_HandleNullOnRead(bool value) { }

	[CompilerGenerated]
	 void set_HandleNullOnWrite(bool value) { }

	[CompilerGenerated]
	internal void set_IsInternalConverter(bool value) { }

	[CompilerGenerated]
	internal void set_IsInternalConverterForNumberType(bool value) { }

	[CompilerGenerated]
	internal void set_IsValueType(bool value) { }

	[CompilerGenerated]
	internal void set_RequiresReadAhead(bool value) { }

	[CompilerGenerated]
	 void set_UsesDefaultHandleNull(bool value) { }

	internal static bool ShouldFlush(Utf8JsonWriter writer, ref WriteStack state) { }

	internal bool TryHandleSerializedObjectReference(Utf8JsonWriter writer, object value, JsonSerializerOptions options, JsonConverter polymorphicConverter, ref WriteStack state) { }

	internal abstract bool TryWriteAsObject(Utf8JsonWriter writer, object value, JsonSerializerOptions options, ref WriteStack state) { }

	internal abstract void WriteAsObject(Utf8JsonWriter writer, object value, JsonSerializerOptions options) { }

	internal abstract void WriteAsPropertyNameAsObject(Utf8JsonWriter writer, object value, JsonSerializerOptions options) { }

	internal abstract void WriteAsPropertyNameCoreAsObject(Utf8JsonWriter writer, object value, JsonSerializerOptions options, bool isWritingExtensionDataProperty) { }

	internal abstract void WriteNumberWithCustomHandlingAsObject(Utf8JsonWriter writer, object value, JsonNumberHandling handling) { }

}

