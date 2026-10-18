namespace System.Text.Json;

[DebuggerDisplay("{DebuggerDisplay,nq}")]
internal struct WriteStack
{
	public WriteStackFrame Current; //Field offset: 0x0
	private WriteStackFrame[] _stack; //Field offset: 0x68
	private int _count; //Field offset: 0x70
	private int _continuationCount; //Field offset: 0x74
	private byte _indexOffset; //Field offset: 0x78
	public CancellationToken CancellationToken; //Field offset: 0x80
	public bool SuppressFlush; //Field offset: 0x88
	public Task PendingTask; //Field offset: 0x90
	public List CompletedAsyncDisposables; //Field offset: 0x98
	public int FlushThreshold; //Field offset: 0xA0
	public ReferenceResolver ReferenceResolver; //Field offset: 0xA8
	public bool SupportContinuation; //Field offset: 0xB0
	public bool SupportAsync; //Field offset: 0xB1
	public string NewReferenceId; //Field offset: 0xB8
	public object PolymorphicTypeDiscriminator; //Field offset: 0xC0
	public PolymorphicTypeResolver PolymorphicTypeResolver; //Field offset: 0xC8

	public bool CurrentContainsMetadata
	{
		[IsReadOnly]
		 get { } //Length: 25
	}

	public int CurrentDepth
	{
		[IsReadOnly]
		 get { } //Length: 4
	}

	public bool IsContinuation
	{
		[IsReadOnly]
		 get { } //Length: 8
	}

	[CompilerGenerated]
	internal static void <DisposePendingDisposablesOnException>g__DisposeFrame|31_0(IEnumerator collectionEnumerator, ref Exception exception) { }

	[CompilerGenerated]
	internal static void <PropertyPath>g__AppendPropertyName|33_1(StringBuilder sb, string propertyName) { }

	[CompilerGenerated]
	internal static void <PropertyPath>g__AppendStackFrame|33_0(StringBuilder sb, ref WriteStackFrame frame) { }

	public void AddCompletedAsyncDisposable(IAsyncDisposable asyncDisposable) { }

	public void DisposePendingDisposablesOnException() { }

	private void EnsurePushCapacity() { }

	[IsReadOnly]
	public bool get_CurrentContainsMetadata() { }

	[IsReadOnly]
	public int get_CurrentDepth() { }

	[IsReadOnly]
	public bool get_IsContinuation() { }

	internal void Initialize(JsonTypeInfo jsonTypeInfo, object rootValueBoxed = null, bool supportContinuation = false, bool supportAsync = false) { }

	[IsReadOnly]
	public JsonTypeInfo PeekNestedJsonTypeInfo() { }

	public void Pop(bool success) { }

	public string PropertyPath() { }

	public void Push() { }

}

