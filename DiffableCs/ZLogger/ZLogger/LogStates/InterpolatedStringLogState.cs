namespace ZLogger.LogStates;

[Nullable(0)]
[NullableContext(1)]
public sealed class InterpolatedStringLogState : IZLoggerFormattable, IZLoggerEntryCreatable, IReferenceCountable, IZLoggerAdditionalInfo, IObjectPoolNode, IEnumerable, IEnumerable
{
	[Nullable(0)]
	private struct Enumerator : IEnumerator, IEnumerator, IDisposable
	{
		private InterpolatedStringLogState state; //Field offset: 0x0
		private int currentIndex; //Field offset: 0x8

		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 2})]
		public override KeyValuePair Current
		{
			 get { } //Length: 201
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 89
		}

		public Enumerator(InterpolatedStringLogState state) { }

		public override void Dispose() { }

		public override KeyValuePair get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

		private override object System.Collections.IEnumerator.get_Current() { }

	}

	private static readonly ObjectPool cache; //Field offset: 0x0
	[Nullable(2)]
	private InterpolatedStringLogState next; //Field offset: 0x10
	[CompilerGenerated]
	private int <ParameterCount>k__BackingField; //Field offset: 0x18
	[Nullable(new IL2CPP_TYPE_U1[] {0, 2, 2, 2})]
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"context", "MemberName", "FilePath", "LineNumber"})]
	internal ValueTuple additionalInfo; //Field offset: 0x20
	private byte[] magicalBoxStorage; //Field offset: 0x40
	internal InterpolatedStringParameter[] parameters; //Field offset: 0x48
	private int refCount; //Field offset: 0x50
	internal MessageSequence messageSequence; //Field offset: 0x58
	internal MagicalBox magicalBox; //Field offset: 0x60
	private short version; //Field offset: 0x70

	public override bool IsSupportUtf8ParameterKey
	{
		 get { } //Length: 3
	}

	[Nullable(2)]
	public override InterpolatedStringLogState NextNode
	{
		[NullableContext(2)]
		 get { } //Length: 5
	}

	public private override int ParameterCount
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public short Version
	{
		 get { } //Length: 5
	}

	private static InterpolatedStringLogState() { }

	private InterpolatedStringLogState() { }

	public static InterpolatedStringLogState Create(int formattedCount) { }

	public IZLoggerEntry CreateEntry(in LogInfo info) { }

	private void DisposeCore() { }

	public override bool get_IsSupportUtf8ParameterKey() { }

	[NullableContext(2)]
	public override InterpolatedStringLogState get_NextNode() { }

	[CompilerGenerated]
	public override int get_ParameterCount() { }

	public short get_Version() { }

	public override ValueTuple GetAdditionalInfo() { }

	public override IEnumerator GetEnumerator() { }

	public override string GetOriginalFormat() { }

	[NullableContext(0)]
	public override ReadOnlySpan GetParameterKey(int index) { }

	public override string GetParameterKeyAsString(int index) { }

	public override Type GetParameterType(int index) { }

	[NullableContext(2)]
	public override object GetParameterValue(int index) { }

	[NullableContext(2)]
	public override T GetParameterValue(int index) { }

	public override void Release() { }

	public override void Retain() { }

	[CompilerGenerated]
	private void set_ParameterCount(int value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public virtual string ToString() { }

	public override void ToString(IBufferWriter writer) { }

	public override void WriteJsonParameterKeyValues(Utf8JsonWriter jsonWriter, JsonSerializerOptions jsonSerializerOptions, IKeyNameMutator keyNameMutator = null) { }

	public override void WriteOriginalFormat(IBufferWriter writer) { }

	private override IZLoggerEntry ZLogger.IZLoggerEntryCreatable.CreateEntry(in LogInfo info) { }

}

