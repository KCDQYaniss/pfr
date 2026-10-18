namespace System.Text.Json.Serialization.Metadata;

[DebuggerDisplay("{DebuggerDisplay,nq}")]
[Nullable(0)]
[NullableContext(2)]
public abstract class JsonTypeInfo
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__201_0; //Field offset: 0x8
		public static Action <>9__206_0; //Field offset: 0x10
		public static Action <>9__206_1; //Field offset: 0x18
		public static Action <>9__206_2; //Field offset: 0x20
		public static Action <>9__206_3; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal int <ConfigureProperties>b__201_0(KeyValuePair propInfo) { }

		internal void <MapInterfaceTypesToCallbacks>b__206_0(object obj) { }

		internal void <MapInterfaceTypesToCallbacks>b__206_1(object obj) { }

		internal void <MapInterfaceTypesToCallbacks>b__206_2(object obj) { }

		internal void <MapInterfaceTypesToCallbacks>b__206_3(object obj) { }

	}

	private enum ConfigurationState
	{
		NotConfigured = 0,
		Configuring = 1,
		Configured = 2,
	}

	public sealed class JsonPropertyInfoList : ConfigurationList
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func <>9__6_0; //Field offset: 0x8

			private static <>c() { }

			public <>c() { }

			internal int <SortProperties>b__6_0(JsonPropertyInfo propInfo) { }

		}

		private readonly JsonTypeInfo _jsonTypeInfo; //Field offset: 0x18

		public virtual bool IsReadOnly
		{
			 get { } //Length: 52
		}

		public JsonPropertyInfoList(JsonTypeInfo jsonTypeInfo) { }

		public void AddPropertyWithConflictResolution(JsonPropertyInfo jsonPropertyInfo, ref PropertyHierarchyResolutionState state) { }

		public virtual bool get_IsReadOnly() { }

		protected virtual void OnCollectionModifying() { }

		public void SortProperties() { }

		protected virtual void ValidateAddedValue(JsonPropertyInfo item) { }

	}

	public sealed class ParameterizedConstructorDelegate`5 : MulticastDelegate
	{

		public ParameterizedConstructorDelegate`5(object object, IntPtr method) { }

		public override T Invoke(TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3) { }

	}

	private sealed class ParameterLookupKey
	{
		[CompilerGenerated]
		private readonly string <Name>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private readonly Type <Type>k__BackingField; //Field offset: 0x18

		public string Name
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public Type Type
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public ParameterLookupKey(string name, Type type) { }

		public virtual bool Equals(object obj) { }

		[CompilerGenerated]
		public string get_Name() { }

		[CompilerGenerated]
		public Type get_Type() { }

		public virtual int GetHashCode() { }

	}

	private sealed class ParameterLookupValue
	{
		[CompilerGenerated]
		private string <DuplicateName>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private readonly JsonPropertyInfo <JsonPropertyInfo>k__BackingField; //Field offset: 0x18

		public string DuplicateName
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 82
		}

		public JsonPropertyInfo JsonPropertyInfo
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public ParameterLookupValue(JsonPropertyInfo jsonPropertyInfo) { }

		[CompilerGenerated]
		public string get_DuplicateName() { }

		[CompilerGenerated]
		public JsonPropertyInfo get_JsonPropertyInfo() { }

		[CompilerGenerated]
		public void set_DuplicateName(string value) { }

	}

	[IsByRefLike]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
	public struct PropertyHierarchyResolutionState
	{
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {null, "index"})]
		public Dictionary AddedProperties; //Field offset: 0x0
		public Dictionary IgnoredProperties; //Field offset: 0x8
		public bool IsPropertyOrderSpecified; //Field offset: 0x10

		public PropertyHierarchyResolutionState(JsonSerializerOptions options) { }

	}

	internal static readonly Type ObjectType; //Field offset: 0x0
	[CompilerGenerated]
	private int <ParameterCount>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private JsonPropertyDictionary <ParameterCache>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private JsonPropertyDictionary <PropertyCache>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private int <NumberOfRequiredProperties>k__BackingField; //Field offset: 0x28
	private Action _onSerializing; //Field offset: 0x30
	private Action _onSerialized; //Field offset: 0x38
	private Action _onDeserializing; //Field offset: 0x40
	private Action _onDeserialized; //Field offset: 0x48
	 Func _createObject; //Field offset: 0x50
	[CompilerGenerated]
	private Func <CreateObjectForExtensionDataProperty>k__BackingField; //Field offset: 0x58
	private Func _sourceGenDelayedPropertyInitializer; //Field offset: 0x60
	private JsonPropertyInfoList _properties; //Field offset: 0x68
	[CompilerGenerated]
	private bool <IsReadOnly>k__BackingField; //Field offset: 0x70
	 JsonPolymorphismOptions _polymorphismOptions; //Field offset: 0x78
	[CompilerGenerated]
	private object <CreateObjectWithArgs>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private object <AddMethodDelegate>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private JsonPropertyInfo <ExtensionDataProperty>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private PolymorphicTypeResolver <PolymorphicTypeResolver>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private bool <HasSerializeHandler>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	private bool <CanUseSerializeHandler>k__BackingField; //Field offset: 0xA1
	[CompilerGenerated]
	private bool <PropertyMetadataSerializationNotSupported>k__BackingField; //Field offset: 0xA2
	[CompilerGenerated]
	private readonly Type <ElementType>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	private readonly Type <KeyType>k__BackingField; //Field offset: 0xB0
	private JsonTypeInfo _elementTypeInfo; //Field offset: 0xB8
	private JsonTypeInfo _keyTypeInfo; //Field offset: 0xC0
	[CompilerGenerated]
	private readonly JsonSerializerOptions <Options>k__BackingField; //Field offset: 0xC8
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; //Field offset: 0xD0
	[CompilerGenerated]
	private readonly JsonConverter <Converter>k__BackingField; //Field offset: 0xD8
	[CompilerGenerated]
	private JsonTypeInfoKind <Kind>k__BackingField; //Field offset: 0xE0
	[CompilerGenerated]
	private readonly JsonPropertyInfo <PropertyInfoForTypeInfo>k__BackingField; //Field offset: 0xE8
	private Nullable _numberHandling; //Field offset: 0xF0
	private Nullable _unmappedMemberHandling; //Field offset: 0xF8
	[CompilerGenerated]
	private JsonUnmappedMemberHandling <EffectiveUnmappedMemberHandling>k__BackingField; //Field offset: 0x100
	private Nullable _preferredPropertyObjectCreationHandling; //Field offset: 0x104
	private IJsonTypeInfoResolver _originatingResolver; //Field offset: 0x110
	[CompilerGenerated]
	private bool <IsCustomized>k__BackingField; //Field offset: 0x118
	private ConfigurationState _configurationState; //Field offset: 0x119
	private ExceptionDispatchInfo _cachedConfigureError; //Field offset: 0x120
	private JsonTypeInfo _ancestorPolymorhicType; //Field offset: 0x128
	private bool _isAncestorPolymorphicTypeResolved; //Field offset: 0x130
	[CompilerGenerated]
	private bool <IsCompatibleWithCurrentOptions>k__BackingField; //Field offset: 0x131
	[CompilerGenerated]
	private JsonParameterInfoValues[] <ParameterInfoValues>k__BackingField; //Field offset: 0x138

	internal object AddMethodDelegate
	{
		[CompilerGenerated]
		internal set { } //Length: 82
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	internal JsonTypeInfo AncestorPolymorphicType
	{
		internal get { } //Length: 151
	}

	internal bool CanUseSerializeHandler
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	[Nullable(1)]
	public JsonConverter Converter
	{
		[CompilerGenerated]
		[NullableContext(1)]
		 get { } //Length: 8
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	public Func CreateObject
	{
		 get { } //Length: 5
		 set { } //Length: 20
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	internal Func CreateObjectForExtensionDataProperty
	{
		[CompilerGenerated]
		internal set { } //Length: 82
	}

	internal object CreateObjectWithArgs
	{
		[CompilerGenerated]
		internal set { } //Length: 82
	}

	private JsonUnmappedMemberHandling EffectiveUnmappedMemberHandling
	{
		[CompilerGenerated]
		private set { } //Length: 7
	}

	internal Type ElementType
	{
		[CompilerGenerated]
		internal get { } //Length: 8
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	internal JsonTypeInfo ElementTypeInfo
	{
		internal get { } //Length: 54
	}

	internal JsonPropertyInfo ExtensionDataProperty
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	internal bool HasSerializeHandler
	{
		[CompilerGenerated]
		internal get { } //Length: 8
	}

	private bool IsCompatibleWithCurrentOptions
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	internal bool IsConfigured
	{
		internal get { } //Length: 18
	}

	internal bool IsCustomized
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 7
	}

	public private bool IsReadOnly
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	internal Type KeyType
	{
		[CompilerGenerated]
		internal get { } //Length: 8
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	internal JsonTypeInfo KeyTypeInfo
	{
		internal get { } //Length: 54
	}

	public private JsonTypeInfoKind Kind
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public Nullable NumberHandling
	{
		 get { } //Length: 8
		 set { } //Length: 231
	}

	private int NumberOfRequiredProperties
	{
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	public Action OnDeserialized
	{
		 set { } //Length: 124
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	public Action OnDeserializing
	{
		 set { } //Length: 124
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	public Action OnSerialized
	{
		 get { } //Length: 5
		 set { } //Length: 124
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	public Action OnSerializing
	{
		 get { } //Length: 76
		 set { } //Length: 124
	}

	[Nullable(1)]
	public JsonSerializerOptions Options
	{
		[CompilerGenerated]
		[NullableContext(1)]
		 get { } //Length: 8
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	public IJsonTypeInfoResolver OriginatingResolver
	{
		 get { } //Length: 8
		 set { } //Length: 212
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private JsonPropertyDictionary ParameterCache
	{
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private int ParameterCount
	{
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	internal JsonParameterInfoValues[] ParameterInfoValues
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 82
	}

	internal PolymorphicTypeResolver PolymorphicTypeResolver
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public JsonPolymorphismOptions PolymorphismOptions
	{
		 get { } //Length: 5
	}

	public Nullable PreferredPropertyObjectCreationHandling
	{
		 get { } //Length: 8
		 set { } //Length: 262
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	internal JsonPropertyDictionary PropertyCache
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[Nullable(1)]
	internal JsonPropertyInfo PropertyInfoForTypeInfo
	{
		[CompilerGenerated]
		internal get { } //Length: 8
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Nullable(1)]
	internal JsonPropertyInfoList PropertyList
	{
		internal get { } //Length: 17
	}

	internal bool PropertyMetadataSerializationNotSupported
	{
		[CompilerGenerated]
		internal get { } //Length: 8
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	internal bool SupportsPolymorphicDeserialization
	{
		internal get { } //Length: 18
	}

	[Nullable(1)]
	public Type Type
	{
		[CompilerGenerated]
		[NullableContext(1)]
		 get { } //Length: 8
	}

	public Nullable UnmappedMemberHandling
	{
		 get { } //Length: 8
		 set { } //Length: 262
	}

	private static JsonTypeInfo() { }

	internal JsonTypeInfo(Type type, JsonConverter converter, JsonSerializerOptions options) { }

	[CompilerGenerated]
	private bool <DetermineIsCompatibleWithCurrentOptions>g__IsCurrentNodeCompatible|178_0() { }

	[CompilerGenerated]
	private void <EnsureConfigured>g__ConfigureSynchronized|172_0() { }

	[CompilerGenerated]
	private JsonPropertyInfoList <get_PropertyList>g__CreatePropertyList|65_0() { }

	private void Configure() { }

	internal void ConfigureConstructorParameters() { }

	internal void ConfigureProperties() { }

	abstract JsonPropertyInfo CreateJsonPropertyInfo(JsonTypeInfo declaringTypeInfo, Type declaringType, JsonSerializerOptions options) { }

	[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
	[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
	internal static JsonTypeInfo CreateJsonTypeInfo(Type type, JsonConverter converter, JsonSerializerOptions options) { }

	internal JsonPropertyDictionary CreatePropertyCache(int capacity) { }

	abstract JsonPropertyInfo CreatePropertyInfoForTypeInfo() { }

	[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
	[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
	internal JsonPropertyInfo CreatePropertyUsingReflection(Type propertyType, Type declaringType) { }

	private void DetermineIsCompatibleWithCurrentOptions() { }

	internal bool DetermineUsesParameterizedConstructor() { }

	internal void EnsureConfigured() { }

	internal JsonTypeInfo get_AncestorPolymorphicType() { }

	[CompilerGenerated]
	internal bool get_CanUseSerializeHandler() { }

	[CompilerGenerated]
	[NullableContext(1)]
	public JsonConverter get_Converter() { }

	public Func get_CreateObject() { }

	[CompilerGenerated]
	internal Type get_ElementType() { }

	internal JsonTypeInfo get_ElementTypeInfo() { }

	[CompilerGenerated]
	internal JsonPropertyInfo get_ExtensionDataProperty() { }

	[CompilerGenerated]
	internal bool get_HasSerializeHandler() { }

	[CompilerGenerated]
	private bool get_IsCompatibleWithCurrentOptions() { }

	internal bool get_IsConfigured() { }

	[CompilerGenerated]
	internal bool get_IsCustomized() { }

	[CompilerGenerated]
	public bool get_IsReadOnly() { }

	[CompilerGenerated]
	internal Type get_KeyType() { }

	internal JsonTypeInfo get_KeyTypeInfo() { }

	[CompilerGenerated]
	public JsonTypeInfoKind get_Kind() { }

	public Nullable get_NumberHandling() { }

	public Action get_OnSerialized() { }

	public Action get_OnSerializing() { }

	[CompilerGenerated]
	[NullableContext(1)]
	public JsonSerializerOptions get_Options() { }

	public IJsonTypeInfoResolver get_OriginatingResolver() { }

	[CompilerGenerated]
	internal JsonParameterInfoValues[] get_ParameterInfoValues() { }

	[CompilerGenerated]
	internal PolymorphicTypeResolver get_PolymorphicTypeResolver() { }

	public JsonPolymorphismOptions get_PolymorphismOptions() { }

	public Nullable get_PreferredPropertyObjectCreationHandling() { }

	[CompilerGenerated]
	internal JsonPropertyDictionary get_PropertyCache() { }

	[CompilerGenerated]
	internal JsonPropertyInfo get_PropertyInfoForTypeInfo() { }

	internal JsonPropertyInfoList get_PropertyList() { }

	[CompilerGenerated]
	internal bool get_PropertyMetadataSerializationNotSupported() { }

	internal bool get_SupportsPolymorphicDeserialization() { }

	[CompilerGenerated]
	[NullableContext(1)]
	public Type get_Type() { }

	public Nullable get_UnmappedMemberHandling() { }

	private static JsonTypeInfoKind GetTypeInfoKind(Type type, JsonConverter converter) { }

	private static bool IsByRefLike(Type type) { }

	internal static bool IsInvalidForSerialization(Type type) { }

	internal static bool IsValidExtensionDataProperty(Type propertyType) { }

	public void MakeReadOnly() { }

	internal void MapInterfaceTypesToCallbacks() { }

	internal void PopulatePolymorphismMetadata() { }

	internal abstract void SerializeAsObject(Utf8JsonWriter writer, object rootValue) { }

	[CompilerGenerated]
	internal void set_AddMethodDelegate(object value) { }

	[CompilerGenerated]
	private void set_CanUseSerializeHandler(bool value) { }

	public void set_CreateObject(Func value) { }

	[CompilerGenerated]
	internal void set_CreateObjectForExtensionDataProperty(Func value) { }

	[CompilerGenerated]
	internal void set_CreateObjectWithArgs(object value) { }

	[CompilerGenerated]
	private void set_EffectiveUnmappedMemberHandling(JsonUnmappedMemberHandling value) { }

	[CompilerGenerated]
	private void set_ExtensionDataProperty(JsonPropertyInfo value) { }

	[CompilerGenerated]
	private void set_IsCompatibleWithCurrentOptions(bool value) { }

	[CompilerGenerated]
	internal void set_IsCustomized(bool value) { }

	[CompilerGenerated]
	private void set_IsReadOnly(bool value) { }

	[CompilerGenerated]
	private void set_Kind(JsonTypeInfoKind value) { }

	public void set_NumberHandling(Nullable value) { }

	[CompilerGenerated]
	private void set_NumberOfRequiredProperties(int value) { }

	public void set_OnDeserialized(Action value) { }

	public void set_OnDeserializing(Action value) { }

	public void set_OnSerialized(Action value) { }

	public void set_OnSerializing(Action value) { }

	public void set_OriginatingResolver(IJsonTypeInfoResolver value) { }

	[CompilerGenerated]
	private void set_ParameterCache(JsonPropertyDictionary value) { }

	[CompilerGenerated]
	private void set_ParameterCount(int value) { }

	[CompilerGenerated]
	internal void set_ParameterInfoValues(JsonParameterInfoValues[] value) { }

	[CompilerGenerated]
	private void set_PolymorphicTypeResolver(PolymorphicTypeResolver value) { }

	public void set_PreferredPropertyObjectCreationHandling(Nullable value) { }

	[CompilerGenerated]
	private void set_PropertyCache(JsonPropertyDictionary value) { }

	public void set_UnmappedMemberHandling(Nullable value) { }

	abstract void SetCreateObject(Delegate createObject) { }

	internal void SetCreateObjectIfCompatible(Delegate createObject) { }

	internal void ValidateCanBeUsedForPropertyMetadataSerialization() { }

	internal static void ValidateType(Type type) { }

	internal void VerifyMutable() { }

}

