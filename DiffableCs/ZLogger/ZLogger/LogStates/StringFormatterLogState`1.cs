namespace ZLogger.LogStates;

[Nullable(0)]
[NullableContext(1)]
internal struct StringFormatterLogState`1 : IZLoggerFormattable, IZLoggerEntryCreatable
{
	[CompilerGenerated]
	private readonly int <ParameterCount>k__BackingField; //Field offset: 0x0
	private readonly TState originalState; //Field offset: 0x0
	[Nullable(2)]
	private readonly Exception exception; //Field offset: 0x0
	[Nullable(new IL2CPP_TYPE_U1[] {1, 1, 2, 1})]
	private readonly Func formatter; //Field offset: 0x0
	[Nullable(new IL2CPP_TYPE_U1[] {2, 0, 1, 2})]
	private readonly IReadOnlyList originalStateParameters; //Field offset: 0x0
	[Nullable(2)]
	private readonly string formattedLog; //Field offset: 0x0

	public override bool IsSupportUtf8ParameterKey
	{
		 get { } //Length: 3
	}

	public override int ParameterCount
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 3
	}

	public StringFormatterLogState`1(TState originalState, Exception exception, Func formatter, bool formatImmediately) { }

	public IZLoggerEntry CreateEntry(in LogInfo info) { }

	public override bool get_IsSupportUtf8ParameterKey() { }

	[CompilerGenerated]
	[IsReadOnly]
	public override int get_ParameterCount() { }

	[NullableContext(2)]
	public object GetContext() { }

	public override string GetOriginalFormat() { }

	[NullableContext(0)]
	public override ReadOnlySpan GetParameterKey(int index) { }

	public override string GetParameterKeyAsString(int index) { }

	public override Type GetParameterType(int index) { }

	[NullableContext(2)]
	public override object GetParameterValue(int index) { }

	[NullableContext(2)]
	public override T GetParameterValue(int index) { }

	public virtual string ToString() { }

	public override void ToString(IBufferWriter writer) { }

	public override void WriteJsonParameterKeyValues(Utf8JsonWriter jsonWriter, JsonSerializerOptions jsonSerializerOptions, IKeyNameMutator keyNameMutator = null) { }

	public override void WriteOriginalFormat(IBufferWriter writer) { }

	private override IZLoggerEntry ZLogger.IZLoggerEntryCreatable.CreateEntry(in LogInfo info) { }

}

