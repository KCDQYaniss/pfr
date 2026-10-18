namespace ZLogger.Formatters;

[Nullable(0)]
[NullableContext(1)]
public class SystemTextJsonZLoggerFormatter : IZLoggerFormatter
{
	[CompilerGenerated]
	private JsonPropertyNames <JsonPropertyNames>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private IncludeProperties <IncludeProperties>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private JsonSerializerOptions <JsonSerializerOptions>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[Nullable(2)]
	private JsonLogInfoFormatter <AdditionalFormatter>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private Nullable <PropertyKeyValuesObjectName>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[Nullable(2)]
	private IKeyNameMutator <KeyNameMutator>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private bool <UseUtcTimestamp>k__BackingField; //Field offset: 0x50
	[Nullable(2)]
	private Utf8JsonWriter jsonWriter; //Field offset: 0x58

	[Nullable(2)]
	public JsonLogInfoFormatter AdditionalFormatter
	{
		[CompilerGenerated]
		[NullableContext(2)]
		 get { } //Length: 5
		[CompilerGenerated]
		[NullableContext(2)]
		 set { } //Length: 82
	}

	public IncludeProperties IncludeProperties
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public JsonPropertyNames JsonPropertyNames
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public JsonSerializerOptions JsonSerializerOptions
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	[Nullable(2)]
	public IKeyNameMutator KeyNameMutator
	{
		[CompilerGenerated]
		[NullableContext(2)]
		 get { } //Length: 5
		[CompilerGenerated]
		[NullableContext(2)]
		 set { } //Length: 82
	}

	public Nullable PropertyKeyValuesObjectName
	{
		[CompilerGenerated]
		 get { } //Length: 21
		[CompilerGenerated]
		 set { } //Length: 98
	}

	public bool UseUtcTimestamp
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	private override bool ZLogger.IZLoggerFormatter.WithLineBreak
	{
		private get { } //Length: 3
	}

	public SystemTextJsonZLoggerFormatter() { }

	[CompilerGenerated]
	internal static bool <WriteMutatedJsonKeyName>g__TryMutate|35_0(ReadOnlySpan source, int bufferSize, Utf8JsonWriter jsonWriter, IKeyNameMutator mutator) { }

	public override void FormatLogEntry(IBufferWriter writer, IZLoggerEntry entry) { }

	private void FormatLogInfo(Utf8JsonWriter jsonWriter, in LogInfo info) { }

	[CompilerGenerated]
	[NullableContext(2)]
	public JsonLogInfoFormatter get_AdditionalFormatter() { }

	[CompilerGenerated]
	public IncludeProperties get_IncludeProperties() { }

	[CompilerGenerated]
	public JsonPropertyNames get_JsonPropertyNames() { }

	[CompilerGenerated]
	public JsonSerializerOptions get_JsonSerializerOptions() { }

	[CompilerGenerated]
	[NullableContext(2)]
	public IKeyNameMutator get_KeyNameMutator() { }

	[CompilerGenerated]
	public Nullable get_PropertyKeyValuesObjectName() { }

	[CompilerGenerated]
	public bool get_UseUtcTimestamp() { }

	private JsonEncodedText LogLevelToEncodedText(LogLevel logLevel) { }

	[CompilerGenerated]
	[NullableContext(2)]
	public void set_AdditionalFormatter(JsonLogInfoFormatter value) { }

	[CompilerGenerated]
	public void set_IncludeProperties(IncludeProperties value) { }

	[CompilerGenerated]
	public void set_JsonPropertyNames(JsonPropertyNames value) { }

	[CompilerGenerated]
	public void set_JsonSerializerOptions(JsonSerializerOptions value) { }

	[CompilerGenerated]
	[NullableContext(2)]
	public void set_KeyNameMutator(IKeyNameMutator value) { }

	[CompilerGenerated]
	public void set_PropertyKeyValuesObjectName(Nullable value) { }

	[CompilerGenerated]
	public void set_UseUtcTimestamp(bool value) { }

	private void WriteException(Utf8JsonWriter jsonWriter, Exception ex) { }

	[NullableContext(0)]
	internal static void WriteMutatedJsonKeyName(ReadOnlySpan keyName, Utf8JsonWriter jsonWriter, IKeyNameMutator mutator = null) { }

	private override bool ZLogger.IZLoggerFormatter.get_WithLineBreak() { }

}

