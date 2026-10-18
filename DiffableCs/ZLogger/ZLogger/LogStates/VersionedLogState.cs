namespace ZLogger.LogStates;

[IsReadOnly]
public struct VersionedLogState : IZLoggerEntryCreatable, IReferenceCountable, IZLoggerAdditionalInfo, IEnumerable, IEnumerable
{
	[Nullable(1)]
	private readonly InterpolatedStringLogState state; //Field offset: 0x0
	private readonly int version; //Field offset: 0x8

	public int Version
	{
		 get { } //Length: 4
	}

	[NullableContext(1)]
	internal VersionedLogState(InterpolatedStringLogState state) { }

	[NullableContext(1)]
	public IZLoggerEntry CreateEntry(in LogInfo info) { }

	public int get_Version() { }

	public override ValueTuple GetAdditionalInfo() { }

	public override IEnumerator GetEnumerator() { }

	public override void Release() { }

	public override void Retain() { }

	[NullableContext(1)]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private void ThrowIfVersionUnmatched() { }

	[NullableContext(1)]
	public virtual string ToString() { }

	private override IZLoggerEntry ZLogger.IZLoggerEntryCreatable.CreateEntry(in LogInfo info) { }

}

