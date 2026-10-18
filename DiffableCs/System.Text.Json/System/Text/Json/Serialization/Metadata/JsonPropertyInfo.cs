namespace System.Text.Json.Serialization.Metadata;

[DebuggerDisplay("{DebuggerDisplay,nq}")]
[Nullable(0)]
[NullableContext(1)]
public abstract class JsonPropertyInfo
{
	internal static readonly JsonPropertyInfo s_missingProperty; //Field offset: 0x0
	[CompilerGenerated]
	private JsonTypeInfo <ParentTypeInfo>k__BackingField; //Field offset: 0x10
	 JsonConverter _effectiveConverter; //Field offset: 0x18
	private JsonConverter _customConverter; //Field offset: 0x20
	 Func _untypedGet; //Field offset: 0x28
	 Action _untypedSet; //Field offset: 0x30
	private bool _isUserSpecifiedSetter; //Field offset: 0x38
	 Func _shouldSerialize; //Field offset: 0x40
	private bool _isUserSpecifiedShouldSerialize; //Field offset: 0x48
	private Nullable _ignoreCondition; //Field offset: 0x4C
	private Nullable _objectCreationHandling; //Field offset: 0x54
	[CompilerGenerated]
	private JsonObjectCreationHandling <EffectiveObjectCreationHandling>k__BackingField; //Field offset: 0x5C
	private ICustomAttributeProvider _attributeProvider; //Field offset: 0x60
	[CompilerGenerated]
	private string <MemberName>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private MemberTypes <MemberType>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private bool <IsVirtual>k__BackingField; //Field offset: 0x74
	private bool _isExtensionDataProperty; //Field offset: 0x75
	private bool _isRequired; //Field offset: 0x76
	[CompilerGenerated]
	private readonly Type <PropertyType>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private bool <IsConfigured>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private bool <IgnoreNullTokensOnRead>k__BackingField; //Field offset: 0x81
	[CompilerGenerated]
	private bool <IgnoreDefaultValuesOnWrite>k__BackingField; //Field offset: 0x82
	[CompilerGenerated]
	private bool <IsForTypeInfo>k__BackingField; //Field offset: 0x83
	private string _name; //Field offset: 0x88
	[CompilerGenerated]
	private byte[] <NameAsUtf8Bytes>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private byte[] <EscapedNameSection>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private readonly JsonSerializerOptions <Options>k__BackingField; //Field offset: 0xA0
	private int _order; //Field offset: 0xA8
	[CompilerGenerated]
	private readonly Type <DeclaringType>k__BackingField; //Field offset: 0xB0
	private JsonTypeInfo _jsonTypeInfo; //Field offset: 0xB8
	[CompilerGenerated]
	private bool <CanSerialize>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	private bool <CanDeserialize>k__BackingField; //Field offset: 0xC1
	[CompilerGenerated]
	private bool <CanDeserializeOrPopulate>k__BackingField; //Field offset: 0xC2
	[CompilerGenerated]
	private bool <SrcGen_HasJsonInclude>k__BackingField; //Field offset: 0xC3
	[CompilerGenerated]
	private bool <SrcGen_IsPublic>k__BackingField; //Field offset: 0xC4
	private Nullable _numberHandling; //Field offset: 0xC8
	[CompilerGenerated]
	private Nullable <EffectiveNumberHandling>k__BackingField; //Field offset: 0xD0
	private int _index; //Field offset: 0xD8

	[Nullable(2)]
	public ICustomAttributeProvider AttributeProvider
	{
		[NullableContext(2)]
		 set { } //Length: 109
	}

	internal bool CanDeserialize
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	private bool CanDeserializeOrPopulate
	{
		[CompilerGenerated]
		private set { } //Length: 7
	}

	internal bool CanSerialize
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	[Nullable(2)]
	public JsonConverter CustomConverter
	{
		[NullableContext(2)]
		 get { } //Length: 5
		[NullableContext(2)]
		 set { } //Length: 109
	}

	internal Type DeclaringType
	{
		[CompilerGenerated]
		internal get { } //Length: 8
	}

	internal JsonConverter EffectiveConverter
	{
		internal get { } //Length: 5
	}

	internal Nullable EffectiveNumberHandling
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	internal JsonObjectCreationHandling EffectiveObjectCreationHandling
	{
		[CompilerGenerated]
		internal get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	internal byte[] EscapedNameSection
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 82
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 2})]
	public Func Get
	{
		 get { } //Length: 5
	}

	internal bool HasGetter
	{
		internal get { } //Length: 9
	}

	internal bool HasSetter
	{
		internal get { } //Length: 9
	}

	internal Nullable IgnoreCondition
	{
		internal set { } //Length: 50
	}

	internal bool IgnoreDefaultValuesOnWrite
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	internal bool IgnoreNullTokensOnRead
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	internal bool IgnoreReadOnlyMember
	{
		internal get { } //Length: 71
	}

	private bool IsConfigured
	{
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public bool IsExtensionData
	{
		 get { } //Length: 5
		 set { } //Length: 158
	}

	internal bool IsForTypeInfo
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 7
	}

	internal bool IsIgnored
	{
		internal get { } //Length: 105
	}

	internal bool IsPropertyTypeInfoConfigured
	{
		internal get { } //Length: 31
	}

	public bool IsRequired
	{
		 get { } //Length: 5
		 set { } //Length: 41
	}

	internal bool IsVirtual
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	internal JsonTypeInfo JsonTypeInfo
	{
		internal get { } //Length: 59
		internal set { } //Length: 82
	}

	[Nullable(2)]
	internal string MemberName
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 82
	}

	internal MemberTypes MemberType
	{
		[CompilerGenerated]
		internal get { } //Length: 4
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	public string Name
	{
		 get { } //Length: 8
		 set { } //Length: 194
	}

	internal byte[] NameAsUtf8Bytes
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 82
	}

	public Nullable NumberHandling
	{
		 get { } //Length: 8
		 set { } //Length: 45
	}

	public Nullable ObjectCreationHandling
	{
		 get { } //Length: 5
		 set { } //Length: 237
	}

	public JsonSerializerOptions Options
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public int Order
	{
		 get { } //Length: 7
		 set { } //Length: 44
	}

	[Nullable(2)]
	internal JsonTypeInfo ParentTypeInfo
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public Type PropertyType
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	internal abstract bool PropertyTypeCanBeNull
	{
		internal get { } //Length: 0
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	internal int RequiredPropertyIndex
	{
		internal set { } //Length: 7
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 2})]
	public Action Set
	{
		 get { } //Length: 76
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 2})]
	public Func ShouldSerialize
	{
		 get { } //Length: 5
	}

	internal bool SrcGen_HasJsonInclude
	{
		[CompilerGenerated]
		internal get { } //Length: 8
	}

	internal bool SrcGen_IsPublic
	{
		[CompilerGenerated]
		internal get { } //Length: 8
	}

	private static JsonPropertyInfo() { }

	internal JsonPropertyInfo(Type declaringType, Type propertyType, JsonTypeInfo declaringTypeInfo, JsonSerializerOptions options) { }

	private void CacheNameAsUtf8BytesAndEscapedNameSection() { }

	internal void Configure() { }

	abstract void ConfigureIgnoreCondition(Nullable ignoreCondition) { }

	internal abstract JsonParameterInfo CreateJsonParameterInfo(JsonParameterInfoValues parameterInfoValues) { }

	abstract void DetermineEffectiveConverter(JsonTypeInfo jsonTypeInfo) { }

	private void DetermineEffectiveObjectCreationHandlingForProperty() { }

	private void DetermineIgnoreCondition() { }

	private void DetermineNumberHandlingForProperty() { }

	private void DetermineNumberHandlingForTypeInfo() { }

	[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
	[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
	internal abstract void DetermineReflectionPropertyAccessors(MemberInfo memberInfo, bool useNonPublicAccessors) { }

	private void DetermineSerializationCapabilities() { }

	internal void EnsureChildOf(JsonTypeInfo parent) { }

	[CompilerGenerated]
	internal bool get_CanDeserialize() { }

	[CompilerGenerated]
	internal bool get_CanSerialize() { }

	[NullableContext(2)]
	public JsonConverter get_CustomConverter() { }

	[CompilerGenerated]
	internal Type get_DeclaringType() { }

	internal JsonConverter get_EffectiveConverter() { }

	[CompilerGenerated]
	internal Nullable get_EffectiveNumberHandling() { }

	[CompilerGenerated]
	internal JsonObjectCreationHandling get_EffectiveObjectCreationHandling() { }

	[CompilerGenerated]
	internal byte[] get_EscapedNameSection() { }

	public Func get_Get() { }

	internal bool get_HasGetter() { }

	internal bool get_HasSetter() { }

	[CompilerGenerated]
	internal bool get_IgnoreDefaultValuesOnWrite() { }

	[CompilerGenerated]
	internal bool get_IgnoreNullTokensOnRead() { }

	internal bool get_IgnoreReadOnlyMember() { }

	public bool get_IsExtensionData() { }

	[CompilerGenerated]
	internal bool get_IsForTypeInfo() { }

	internal bool get_IsIgnored() { }

	internal bool get_IsPropertyTypeInfoConfigured() { }

	public bool get_IsRequired() { }

	[CompilerGenerated]
	internal bool get_IsVirtual() { }

	internal JsonTypeInfo get_JsonTypeInfo() { }

	[CompilerGenerated]
	internal string get_MemberName() { }

	[CompilerGenerated]
	internal MemberTypes get_MemberType() { }

	public string get_Name() { }

	[CompilerGenerated]
	internal byte[] get_NameAsUtf8Bytes() { }

	public Nullable get_NumberHandling() { }

	public Nullable get_ObjectCreationHandling() { }

	[CompilerGenerated]
	public JsonSerializerOptions get_Options() { }

	public int get_Order() { }

	[CompilerGenerated]
	internal JsonTypeInfo get_ParentTypeInfo() { }

	[CompilerGenerated]
	public Type get_PropertyType() { }

	internal abstract bool get_PropertyTypeCanBeNull() { }

	public Action get_Set() { }

	public Func get_ShouldSerialize() { }

	[CompilerGenerated]
	internal bool get_SrcGen_HasJsonInclude() { }

	[CompilerGenerated]
	internal bool get_SrcGen_IsPublic() { }

	internal abstract bool GetMemberAndWriteJson(object obj, ref WriteStack state, Utf8JsonWriter writer) { }

	internal abstract bool GetMemberAndWriteJsonExtensionData(object obj, ref WriteStack state, Utf8JsonWriter writer) { }

	internal static JsonPropertyInfo GetPropertyPlaceholder() { }

	internal bool IsOverriddenOrShadowedBy(JsonPropertyInfo other) { }

	private bool NumberHandingIsApplicable() { }

	[NullableContext(2)]
	public void set_AttributeProvider(ICustomAttributeProvider value) { }

	[CompilerGenerated]
	private void set_CanDeserialize(bool value) { }

	[CompilerGenerated]
	private void set_CanDeserializeOrPopulate(bool value) { }

	[CompilerGenerated]
	private void set_CanSerialize(bool value) { }

	[NullableContext(2)]
	public void set_CustomConverter(JsonConverter value) { }

	[CompilerGenerated]
	internal void set_EffectiveNumberHandling(Nullable value) { }

	[CompilerGenerated]
	private void set_EffectiveObjectCreationHandling(JsonObjectCreationHandling value) { }

	[CompilerGenerated]
	internal void set_EscapedNameSection(byte[] value) { }

	internal void set_IgnoreCondition(Nullable value) { }

	[CompilerGenerated]
	 void set_IgnoreDefaultValuesOnWrite(bool value) { }

	[CompilerGenerated]
	 void set_IgnoreNullTokensOnRead(bool value) { }

	[CompilerGenerated]
	private void set_IsConfigured(bool value) { }

	public void set_IsExtensionData(bool value) { }

	[CompilerGenerated]
	internal void set_IsForTypeInfo(bool value) { }

	public void set_IsRequired(bool value) { }

	[CompilerGenerated]
	internal void set_IsVirtual(bool value) { }

	internal void set_JsonTypeInfo(JsonTypeInfo value) { }

	[CompilerGenerated]
	internal void set_MemberName(string value) { }

	[CompilerGenerated]
	internal void set_MemberType(MemberTypes value) { }

	public void set_Name(string value) { }

	[CompilerGenerated]
	internal void set_NameAsUtf8Bytes(byte[] value) { }

	public void set_NumberHandling(Nullable value) { }

	public void set_ObjectCreationHandling(Nullable value) { }

	public void set_Order(int value) { }

	[CompilerGenerated]
	private void set_ParentTypeInfo(JsonTypeInfo value) { }

	internal void set_RequiredPropertyIndex(int value) { }

	abstract void SetGetter(Delegate getter) { }

	abstract void SetSetter(Delegate setter) { }

	abstract void SetShouldSerialize(Delegate predicate) { }

	 void VerifyMutable() { }

}

