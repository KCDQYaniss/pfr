namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(2)]
public class JsonSerializerSettings
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass93_0
	{
		[Nullable(0)]
		public IReferenceResolver value; //Field offset: 0x10

		public <>c__DisplayClass93_0() { }

		internal IReferenceResolver <set_ReferenceResolver>b__0() { }

	}

	internal const ReferenceLoopHandling DefaultReferenceLoopHandling = 0; //Field offset: 0x0
	internal const int DefaultMaxDepth = 64; //Field offset: 0x0
	[Nullable(1)]
	internal const string DefaultDateFormatString = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK"; //Field offset: 0x0
	internal const bool DefaultCheckAdditionalContent = False; //Field offset: 0x0
	internal const TypeNameAssemblyFormatHandling DefaultTypeNameAssemblyFormatHandling = 0; //Field offset: 0x0
	internal const StringEscapeHandling DefaultStringEscapeHandling = 0; //Field offset: 0x0
	internal const FloatFormatHandling DefaultFloatFormatHandling = 0; //Field offset: 0x0
	internal const FloatParseHandling DefaultFloatParseHandling = 0; //Field offset: 0x0
	internal const DateParseHandling DefaultDateParseHandling = 1; //Field offset: 0x0
	internal const DateFormatHandling DefaultDateFormatHandling = 0; //Field offset: 0x0
	internal const DateTimeZoneHandling DefaultDateTimeZoneHandling = 3; //Field offset: 0x0
	internal static readonly StreamingContext DefaultContext; //Field offset: 0x0
	internal const MetadataPropertyHandling DefaultMetadataPropertyHandling = 0; //Field offset: 0x0
	internal const TypeNameHandling DefaultTypeNameHandling = 0; //Field offset: 0x0
	internal const ConstructorHandling DefaultConstructorHandling = 0; //Field offset: 0x0
	internal const PreserveReferencesHandling DefaultPreserveReferencesHandling = 0; //Field offset: 0x0
	internal const ObjectCreationHandling DefaultObjectCreationHandling = 0; //Field offset: 0x0
	internal const DefaultValueHandling DefaultDefaultValueHandling = 0; //Field offset: 0x0
	internal const NullValueHandling DefaultNullValueHandling = 0; //Field offset: 0x0
	internal const MissingMemberHandling DefaultMissingMemberHandling = 0; //Field offset: 0x0
	internal const Formatting DefaultFormatting = 0; //Field offset: 0x0
	[Nullable(1)]
	internal static readonly CultureInfo DefaultCulture; //Field offset: 0x10
	internal Nullable _formatting; //Field offset: 0x10
	internal Nullable _dateFormatHandling; //Field offset: 0x18
	internal Nullable _dateTimeZoneHandling; //Field offset: 0x20
	internal Nullable _dateParseHandling; //Field offset: 0x28
	internal Nullable _floatFormatHandling; //Field offset: 0x30
	internal Nullable _floatParseHandling; //Field offset: 0x38
	internal Nullable _stringEscapeHandling; //Field offset: 0x40
	internal CultureInfo _culture; //Field offset: 0x48
	internal Nullable _checkAdditionalContent; //Field offset: 0x50
	internal Nullable _maxDepth; //Field offset: 0x54
	internal bool _maxDepthSet; //Field offset: 0x5C
	internal string _dateFormatString; //Field offset: 0x60
	internal bool _dateFormatStringSet; //Field offset: 0x68
	internal Nullable _typeNameAssemblyFormatHandling; //Field offset: 0x6C
	internal Nullable _defaultValueHandling; //Field offset: 0x74
	internal Nullable _preserveReferencesHandling; //Field offset: 0x7C
	internal Nullable _nullValueHandling; //Field offset: 0x84
	internal Nullable _objectCreationHandling; //Field offset: 0x8C
	internal Nullable _missingMemberHandling; //Field offset: 0x94
	internal Nullable _referenceLoopHandling; //Field offset: 0x9C
	internal Nullable _context; //Field offset: 0xA8
	internal Nullable _constructorHandling; //Field offset: 0xC0
	internal Nullable _typeNameHandling; //Field offset: 0xC8
	internal Nullable _metadataPropertyHandling; //Field offset: 0xD0
	[CompilerGenerated]
	[Nullable(1)]
	private IList <Converters>k__BackingField; //Field offset: 0xD8
	[CompilerGenerated]
	private IContractResolver <ContractResolver>k__BackingField; //Field offset: 0xE0
	[CompilerGenerated]
	private IEqualityComparer <EqualityComparer>k__BackingField; //Field offset: 0xE8
	[CompilerGenerated]
	private Func <ReferenceResolverProvider>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	private ITraceWriter <TraceWriter>k__BackingField; //Field offset: 0xF8
	[CompilerGenerated]
	private ISerializationBinder <SerializationBinder>k__BackingField; //Field offset: 0x100
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private EventHandler <Error>k__BackingField; //Field offset: 0x108

	[Obsolete("Binder is obsolete. Use SerializationBinder instead.")]
	public SerializationBinder Binder
	{
		 get { } //Length: 193
		 set { } //Length: 286
	}

	public bool CheckAdditionalContent
	{
		 get { } //Length: 62
		 set { } //Length: 78
	}

	public ConstructorHandling ConstructorHandling
	{
		 get { } //Length: 66
		 set { } //Length: 89
	}

	public StreamingContext Context
	{
		 get { } //Length: 197
		 set { } //Length: 276
	}

	public IContractResolver ContractResolver
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	[Nullable(1)]
	public IList Converters
	{
		[CompilerGenerated]
		[NullableContext(1)]
		 get { } //Length: 8
		[CompilerGenerated]
		[NullableContext(1)]
		 set { } //Length: 82
	}

	[Nullable(1)]
	public CultureInfo Culture
	{
		[NullableContext(1)]
		 get { } //Length: 99
		[NullableContext(1)]
		 set { } //Length: 82
	}

	public DateFormatHandling DateFormatHandling
	{
		 get { } //Length: 60
		 set { } //Length: 86
	}

	[Nullable(1)]
	public string DateFormatString
	{
		[NullableContext(1)]
		 get { } //Length: 66
		[NullableContext(1)]
		 set { } //Length: 92
	}

	public DateParseHandling DateParseHandling
	{
		 get { } //Length: 88
		 set { } //Length: 86
	}

	public DateTimeZoneHandling DateTimeZoneHandling
	{
		 get { } //Length: 88
		 set { } //Length: 86
	}

	public DefaultValueHandling DefaultValueHandling
	{
		 get { } //Length: 60
		 set { } //Length: 86
	}

	public IEqualityComparer EqualityComparer
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	public EventHandler Error
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public FloatFormatHandling FloatFormatHandling
	{
		 get { } //Length: 60
		 set { } //Length: 86
	}

	public FloatParseHandling FloatParseHandling
	{
		 get { } //Length: 60
		 set { } //Length: 86
	}

	public Formatting Formatting
	{
		 get { } //Length: 60
		 set { } //Length: 86
	}

	public Nullable MaxDepth
	{
		 get { } //Length: 91
		 set { } //Length: 191
	}

	public MetadataPropertyHandling MetadataPropertyHandling
	{
		 get { } //Length: 66
		 set { } //Length: 89
	}

	public MissingMemberHandling MissingMemberHandling
	{
		 get { } //Length: 66
		 set { } //Length: 89
	}

	public NullValueHandling NullValueHandling
	{
		 get { } //Length: 66
		 set { } //Length: 89
	}

	public ObjectCreationHandling ObjectCreationHandling
	{
		 get { } //Length: 66
		 set { } //Length: 89
	}

	public PreserveReferencesHandling PreserveReferencesHandling
	{
		 get { } //Length: 66
		 set { } //Length: 86
	}

	public ReferenceLoopHandling ReferenceLoopHandling
	{
		 get { } //Length: 66
		 set { } //Length: 89
	}

	[Obsolete("ReferenceResolver property is obsolete. Use the ReferenceResolverProvider property to set the IReferenceResolver: settings.ReferenceResolverProvider = () => resolver")]
	public IReferenceResolver ReferenceResolver
	{
		 get { } //Length: 30
		 set { } //Length: 387
	}

	public Func ReferenceResolverProvider
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public ISerializationBinder SerializationBinder
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public StringEscapeHandling StringEscapeHandling
	{
		 get { } //Length: 60
		 set { } //Length: 86
	}

	public ITraceWriter TraceWriter
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	[Obsolete("TypeNameAssemblyFormat is obsolete. Use TypeNameAssemblyFormatHandling instead.")]
	public FormatterAssemblyStyle TypeNameAssemblyFormat
	{
		 get { } //Length: 60
		 set { } //Length: 86
	}

	public TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling
	{
		 get { } //Length: 60
		 set { } //Length: 86
	}

	public TypeNameHandling TypeNameHandling
	{
		 get { } //Length: 66
		 set { } //Length: 89
	}

	private static JsonSerializerSettings() { }

	[DebuggerStepThrough]
	public JsonSerializerSettings() { }

	public SerializationBinder get_Binder() { }

	public bool get_CheckAdditionalContent() { }

	public ConstructorHandling get_ConstructorHandling() { }

	public StreamingContext get_Context() { }

	[CompilerGenerated]
	public IContractResolver get_ContractResolver() { }

	[CompilerGenerated]
	[NullableContext(1)]
	public IList get_Converters() { }

	[NullableContext(1)]
	public CultureInfo get_Culture() { }

	public DateFormatHandling get_DateFormatHandling() { }

	[NullableContext(1)]
	public string get_DateFormatString() { }

	public DateParseHandling get_DateParseHandling() { }

	public DateTimeZoneHandling get_DateTimeZoneHandling() { }

	public DefaultValueHandling get_DefaultValueHandling() { }

	[CompilerGenerated]
	public IEqualityComparer get_EqualityComparer() { }

	[CompilerGenerated]
	public EventHandler get_Error() { }

	public FloatFormatHandling get_FloatFormatHandling() { }

	public FloatParseHandling get_FloatParseHandling() { }

	public Formatting get_Formatting() { }

	public Nullable get_MaxDepth() { }

	public MetadataPropertyHandling get_MetadataPropertyHandling() { }

	public MissingMemberHandling get_MissingMemberHandling() { }

	public NullValueHandling get_NullValueHandling() { }

	public ObjectCreationHandling get_ObjectCreationHandling() { }

	public PreserveReferencesHandling get_PreserveReferencesHandling() { }

	public ReferenceLoopHandling get_ReferenceLoopHandling() { }

	public IReferenceResolver get_ReferenceResolver() { }

	[CompilerGenerated]
	public Func get_ReferenceResolverProvider() { }

	[CompilerGenerated]
	public ISerializationBinder get_SerializationBinder() { }

	public StringEscapeHandling get_StringEscapeHandling() { }

	[CompilerGenerated]
	public ITraceWriter get_TraceWriter() { }

	public FormatterAssemblyStyle get_TypeNameAssemblyFormat() { }

	public TypeNameAssemblyFormatHandling get_TypeNameAssemblyFormatHandling() { }

	public TypeNameHandling get_TypeNameHandling() { }

	public void set_Binder(SerializationBinder value) { }

	public void set_CheckAdditionalContent(bool value) { }

	public void set_ConstructorHandling(ConstructorHandling value) { }

	public void set_Context(StreamingContext value) { }

	[CompilerGenerated]
	public void set_ContractResolver(IContractResolver value) { }

	[CompilerGenerated]
	[NullableContext(1)]
	public void set_Converters(IList value) { }

	[NullableContext(1)]
	public void set_Culture(CultureInfo value) { }

	public void set_DateFormatHandling(DateFormatHandling value) { }

	[NullableContext(1)]
	public void set_DateFormatString(string value) { }

	public void set_DateParseHandling(DateParseHandling value) { }

	public void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	public void set_DefaultValueHandling(DefaultValueHandling value) { }

	[CompilerGenerated]
	public void set_EqualityComparer(IEqualityComparer value) { }

	[CompilerGenerated]
	public void set_Error(EventHandler value) { }

	public void set_FloatFormatHandling(FloatFormatHandling value) { }

	public void set_FloatParseHandling(FloatParseHandling value) { }

	public void set_Formatting(Formatting value) { }

	public void set_MaxDepth(Nullable value) { }

	public void set_MetadataPropertyHandling(MetadataPropertyHandling value) { }

	public void set_MissingMemberHandling(MissingMemberHandling value) { }

	public void set_NullValueHandling(NullValueHandling value) { }

	public void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	public void set_PreserveReferencesHandling(PreserveReferencesHandling value) { }

	public void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	public void set_ReferenceResolver(IReferenceResolver value) { }

	[CompilerGenerated]
	public void set_ReferenceResolverProvider(Func value) { }

	[CompilerGenerated]
	public void set_SerializationBinder(ISerializationBinder value) { }

	public void set_StringEscapeHandling(StringEscapeHandling value) { }

	[CompilerGenerated]
	public void set_TraceWriter(ITraceWriter value) { }

	public void set_TypeNameAssemblyFormat(FormatterAssemblyStyle value) { }

	public void set_TypeNameAssemblyFormatHandling(TypeNameAssemblyFormatHandling value) { }

	public void set_TypeNameHandling(TypeNameHandling value) { }

}

