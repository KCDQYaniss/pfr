namespace System.Text.Json;

[DebuggerDisplay("{DebuggerDisplay,nq}")]
[Nullable(0)]
[NullableContext(2)]
public sealed class JsonSerializerOptions
{
	public sealed class CachingContext
	{
		private sealed class CacheEntry
		{
			public readonly bool HasResult; //Field offset: 0x10
			public readonly JsonTypeInfo TypeInfo; //Field offset: 0x18
			public readonly ExceptionDispatchInfo ExceptionDispatchInfo; //Field offset: 0x20
			public bool IsNearestAncestorResolved; //Field offset: 0x28
			public CacheEntry NearestAncestor; //Field offset: 0x30

			public CacheEntry(JsonTypeInfo typeInfo) { }

			public CacheEntry(ExceptionDispatchInfo exception) { }

			public JsonTypeInfo GetResult() { }

		}

		private readonly ConcurrentDictionary _cache; //Field offset: 0x10
		private readonly Func _cacheEntryFactory; //Field offset: 0x18
		[CompilerGenerated]
		private readonly JsonSerializerOptions <Options>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		private readonly int <HashCode>k__BackingField; //Field offset: 0x28

		public int HashCode
		{
			[CompilerGenerated]
			 get { } //Length: 4
		}

		public JsonSerializerOptions Options
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public CachingContext(JsonSerializerOptions options, int hashCode) { }

		[CompilerGenerated]
		private CacheEntry <.ctor>b__2_0(Type type) { }

		public void Clear() { }

		private static CacheEntry CreateCacheEntry(Type type, CachingContext context) { }

		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2070:UnrecognizedReflectionPattern", Justification = "We only need to examine the interface types that are supported by the underlying resolver.")]
		private CacheEntry DetermineNearestAncestor(Type type, CacheEntry entry) { }

		private JsonTypeInfo FallBackToNearestAncestor(Type type, CacheEntry entry) { }

		[CompilerGenerated]
		public int get_HashCode() { }

		[CompilerGenerated]
		public JsonSerializerOptions get_Options() { }

		private CacheEntry GetOrAddCacheEntry(Type type) { }

		public JsonTypeInfo GetOrAddTypeInfo(Type type, bool fallBackToNearestAncestorType = false) { }

		public bool TryGetTypeInfo(Type type, out JsonTypeInfo typeInfo) { }

	}

	private sealed class ConverterList : ConfigurationList
	{
		private readonly JsonSerializerOptions _options; //Field offset: 0x18

		public virtual bool IsReadOnly
		{
			 get { } //Length: 35
		}

		public ConverterList(JsonSerializerOptions options, IList source = null) { }

		public virtual bool get_IsReadOnly() { }

		protected virtual void OnCollectionModifying() { }

	}

	private sealed class EqualityComparer : IEqualityComparer
	{
		private struct HashCode
		{
			private int _hashCode; //Field offset: 0x0

			public void Add(T value) { }

			public int ToHashCode() { }

		}


		public EqualityComparer() { }

		[CompilerGenerated]
		internal static bool <Equals>g__CompareLists|0_0(ConfigurationList left, ConfigurationList right) { }

		[CompilerGenerated]
		internal static void <GetHashCode>g__AddHashCode|1_1(ref HashCode hc, TValue value) { }

		[CompilerGenerated]
		internal static void <GetHashCode>g__AddListHashCode|1_0(ref HashCode hc, ConfigurationList list) { }

		public override bool Equals(JsonSerializerOptions left, JsonSerializerOptions right) { }

		public override int GetHashCode(JsonSerializerOptions options) { }

	}

	private sealed class OptionsBoundJsonTypeInfoResolverChain : JsonTypeInfoResolverChain
	{

	}

	public static class TrackedCachingContexts
	{
		private static readonly WeakReference[] s_trackedContexts; //Field offset: 0x0
		private static readonly EqualityComparer s_optionsComparer; //Field offset: 0x8

		private static TrackedCachingContexts() { }

		public static CachingContext GetOrCreate(JsonSerializerOptions options) { }

		private static bool TryGetContext(JsonSerializerOptions options, int hashCode, out int firstUnpopulatedIndex, out CachingContext result) { }

	}

	public static class TrackedOptionsInstances
	{
		[CompilerGenerated]
		private static readonly ConditionalWeakTable <All>k__BackingField; //Field offset: 0x0

		public static ConditionalWeakTable All
		{
			[CompilerGenerated]
			 get { } //Length: 83
		}

		private static TrackedOptionsInstances() { }

		[CompilerGenerated]
		public static ConditionalWeakTable get_All() { }

	}

	private static JsonSerializerOptions s_defaultOptions; //Field offset: 0x0
	private CachingContext _cachingContext; //Field offset: 0x10
	private JsonTypeInfo _lastTypeInfo; //Field offset: 0x18
	private JsonTypeInfo _objectTypeInfo; //Field offset: 0x20
	private IJsonTypeInfoResolver _typeInfoResolver; //Field offset: 0x28
	private JsonNamingPolicy _dictionaryKeyPolicy; //Field offset: 0x30
	private JsonNamingPolicy _jsonPropertyNamingPolicy; //Field offset: 0x38
	private JsonCommentHandling _readCommentHandling; //Field offset: 0x40
	private ReferenceHandler _referenceHandler; //Field offset: 0x48
	private JavaScriptEncoder _encoder; //Field offset: 0x50
	private ConverterList _converters; //Field offset: 0x58
	private JsonIgnoreCondition _defaultIgnoreCondition; //Field offset: 0x60
	private JsonNumberHandling _numberHandling; //Field offset: 0x64
	private JsonObjectCreationHandling _preferredObjectCreationHandling; //Field offset: 0x68
	private JsonUnknownTypeHandling _unknownTypeHandling; //Field offset: 0x6C
	private JsonUnmappedMemberHandling _unmappedMemberHandling; //Field offset: 0x70
	private int _defaultBufferSize; //Field offset: 0x74
	private int _maxDepth; //Field offset: 0x78
	private bool _allowTrailingCommas; //Field offset: 0x7C
	private bool _ignoreNullValues; //Field offset: 0x7D
	private bool _ignoreReadOnlyProperties; //Field offset: 0x7E
	private bool _ignoreReadonlyFields; //Field offset: 0x7F
	private bool _includeFields; //Field offset: 0x80
	private bool _propertyNameCaseInsensitive; //Field offset: 0x81
	private bool _writeIndented; //Field offset: 0x82
	private OptionsBoundJsonTypeInfoResolverChain _typeInfoResolverChain; //Field offset: 0x88
	[CompilerGenerated]
	private int <EffectiveMaxDepth>k__BackingField; //Field offset: 0x90
	private Nullable _canUseFastPathSerializationLogic; //Field offset: 0x94
	internal ReferenceHandlingStrategy ReferenceHandlingStrategy; //Field offset: 0x98
	private bool _isReadOnly; //Field offset: 0x9C
	private bool _isConfiguredForJsonSerializer; //Field offset: 0x9D
	private IJsonTypeInfoResolver _effectiveJsonTypeInfoResolver; //Field offset: 0xA0

	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Nullable(1)]
	internal CachingContext CacheContext
	{
		internal get { } //Length: 170
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	internal bool CanUseFastPathSerializationLogic
	{
		internal get { } //Length: 191
	}

	[Nullable(1)]
	public IList Converters
	{
		[NullableContext(1)]
		 get { } //Length: 175
	}

	[Nullable(1)]
	public static JsonSerializerOptions Default
	{
		[NullableContext(1)]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		 get { } //Length: 75
	}

	public int DefaultBufferSize
	{
		 get { } //Length: 4
	}

	public JsonIgnoreCondition DefaultIgnoreCondition
	{
		 get { } //Length: 4
		 set { } //Length: 304
	}

	public JsonNamingPolicy DictionaryKeyPolicy
	{
		 get { } //Length: 76
	}

	internal int EffectiveMaxDepth
	{
		[CompilerGenerated]
		internal get { } //Length: 7
	}

	public JavaScriptEncoder Encoder
	{
		 get { } //Length: 5
		 set { } //Length: 182
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("JsonSerializerOptions.IgnoreNullValues is obsolete. To ignore null values when serializing, set DefaultIgnoreCondition to JsonIgnoreCondition.WhenWritingNull.", DiagnosticId = "SYSLIB0020", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
	public bool IgnoreNullValues
	{
		 get { } //Length: 5
	}

	public bool IgnoreReadOnlyFields
	{
		 get { } //Length: 5
	}

	public bool IgnoreReadOnlyProperties
	{
		 get { } //Length: 5
	}

	public bool IncludeFields
	{
		 get { } //Length: 8
	}

	public bool IsReadOnly
	{
		 get { } //Length: 13
	}

	public JsonNumberHandling NumberHandling
	{
		 get { } //Length: 4
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Nullable(1)]
	internal JsonTypeInfo ObjectTypeInfo
	{
		internal get { } //Length: 250
	}

	public JsonObjectCreationHandling PreferredObjectCreationHandling
	{
		 get { } //Length: 4
	}

	public bool PropertyNameCaseInsensitive
	{
		 get { } //Length: 8
	}

	public JsonNamingPolicy PropertyNamingPolicy
	{
		 get { } //Length: 5
	}

	public ReferenceHandler ReferenceHandler
	{
		 get { } //Length: 5
	}

	public IJsonTypeInfoResolver TypeInfoResolver
	{
		 get { } //Length: 5
		 set { } //Length: 337
	}

	public JsonUnmappedMemberHandling UnmappedMemberHandling
	{
		 get { } //Length: 4
	}

	public bool WriteIndented
	{
		 get { } //Length: 8
		 set { } //Length: 109
	}

	public JsonSerializerOptions() { }

	internal static void CheckConverterNullabilityIsSameAsPropertyType(JsonConverter converter, Type propertyType) { }

	[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
	[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
	private void ConfigureForJsonSerializer() { }

	internal JsonConverter ExpandConverterFactory(JsonConverter converter, Type typeToConvert) { }

	internal CachingContext get_CacheContext() { }

	internal bool get_CanUseFastPathSerializationLogic() { }

	[NullableContext(1)]
	public IList get_Converters() { }

	[NullableContext(1)]
	[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
	[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
	public static JsonSerializerOptions get_Default() { }

	public int get_DefaultBufferSize() { }

	public JsonIgnoreCondition get_DefaultIgnoreCondition() { }

	public JsonNamingPolicy get_DictionaryKeyPolicy() { }

	[CompilerGenerated]
	internal int get_EffectiveMaxDepth() { }

	public JavaScriptEncoder get_Encoder() { }

	public bool get_IgnoreNullValues() { }

	public bool get_IgnoreReadOnlyFields() { }

	public bool get_IgnoreReadOnlyProperties() { }

	public bool get_IncludeFields() { }

	public bool get_IsReadOnly() { }

	public JsonNumberHandling get_NumberHandling() { }

	internal JsonTypeInfo get_ObjectTypeInfo() { }

	public JsonObjectCreationHandling get_PreferredObjectCreationHandling() { }

	public bool get_PropertyNameCaseInsensitive() { }

	public JsonNamingPolicy get_PropertyNamingPolicy() { }

	public ReferenceHandler get_ReferenceHandler() { }

	public IJsonTypeInfoResolver get_TypeInfoResolver() { }

	public JsonUnmappedMemberHandling get_UnmappedMemberHandling() { }

	public bool get_WriteIndented() { }

	internal JsonConverter GetConverterFromList(Type typeToConvert) { }

	internal JsonConverter GetConverterInternal(Type typeToConvert) { }

	internal JsonNodeOptions GetNodeOptions() { }

	[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
	[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
	private static JsonSerializerOptions GetOrCreateDefaultOptionsInstance() { }

	internal JsonTypeInfo GetTypeInfoForRootType(Type type, bool fallBackToNearestAncestorType = false) { }

	internal JsonTypeInfo GetTypeInfoInternal(Type type, bool ensureConfigured = true, Nullable ensureNotNull = null, bool resolveIfMutable = false, bool fallBackToNearestAncestorType = false) { }

	private JsonTypeInfo GetTypeInfoNoCaching(Type type) { }

	internal JsonWriterOptions GetWriterOptions() { }

	public void MakeReadOnly() { }

	[RequiresDynamicCode("Populating unconfigured TypeInfoResolver properties with the reflection resolver requires runtime code generation.")]
	[RequiresUnreferencedCode("Populating unconfigured TypeInfoResolver properties with the reflection resolver requires unreferenced code.")]
	public void MakeReadOnly(bool populateMissingResolver) { }

	public void set_DefaultIgnoreCondition(JsonIgnoreCondition value) { }

	public void set_Encoder(JavaScriptEncoder value) { }

	public void set_TypeInfoResolver(IJsonTypeInfoResolver value) { }

	public void set_WriteIndented(bool value) { }

	private static void TrackOptionsInstance(JsonSerializerOptions options) { }

	internal bool TryGetPolymorphicTypeInfoForRootType(object rootValue, out JsonTypeInfo polymorphicTypeInfo) { }

	internal bool TryGetTypeInfoCached(Type type, out JsonTypeInfo typeInfo) { }

	internal void VerifyMutable() { }

}

