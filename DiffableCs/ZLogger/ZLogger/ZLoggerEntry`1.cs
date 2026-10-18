namespace ZLogger;

[Nullable(0)]
[NullableContext(1)]
public sealed class ZLoggerEntry`1 : IZLoggerEntry, INonReturnableZLoggerEntry, IZLoggerFormattable, IZLoggerEntryCreatable, IObjectPoolNode
{
	private static readonly ObjectPool cache; //Field offset: 0x0
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private ZLoggerEntry next; //Field offset: 0x0
	private LogInfo logInfo; //Field offset: 0x0
	private TState state; //Field offset: 0x0

	public override bool IsSupportUtf8ParameterKey
	{
		 get { } //Length: 3
	}

	public override LogInfo LogInfo
	{
		 get { } //Length: 100
	}

	public override int ParameterCount
	{
		 get { } //Length: 7
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private override ZLoggerEntry ZLogger.Internal.IObjectPoolNode<ZLogger.ZLoggerEntry<TState>>.NextNode
	{
		private get { } //Length: 5
	}

	private static ZLoggerEntry`1() { }

	private ZLoggerEntry`1(in LogInfo logInfo, in TState state) { }

	public static ZLoggerEntry Create(in LogInfo logInfo, in TState state) { }

	public IZLoggerEntry CreateEntry(in LogInfo info) { }

	public override void FormatUtf8(IBufferWriter writer, IZLoggerFormatter formatter) { }

	public override bool get_IsSupportUtf8ParameterKey() { }

	public override LogInfo get_LogInfo() { }

	public override int get_ParameterCount() { }

	public override string GetOriginalFormat() { }

	[NullableContext(0)]
	public override ReadOnlySpan GetParameterKey(int index) { }

	public override string GetParameterKeyAsString(int index) { }

	public override Type GetParameterType(int index) { }

	[NullableContext(2)]
	public override object GetParameterValue(int index) { }

	[NullableContext(2)]
	public override T GetParameterValue(int index) { }

	public override void Return() { }

	public virtual string ToString() { }

	public override void ToString(IBufferWriter writer) { }

	public override void WriteJsonParameterKeyValues(Utf8JsonWriter jsonWriter, JsonSerializerOptions jsonSerializerOptions, IKeyNameMutator keyNameMutator = null) { }

	public override void WriteOriginalFormat(IBufferWriter writer) { }

	private override ZLoggerEntry ZLogger.Internal.IObjectPoolNode<ZLogger.ZLoggerEntry<TState>>.get_NextNode() { }

	private override IZLoggerEntry ZLogger.IZLoggerEntryCreatable.CreateEntry(in LogInfo info) { }

}

