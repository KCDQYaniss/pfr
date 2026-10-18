namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(2)]
public abstract class JsonReader : IDisposable
{
	[CompilerGenerated]
	private struct <MoveToContentFromNonContentAsync>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadAndMoveToContentAsync>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadArrayIntoByteArrayAsync>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		private List <buffer>5__2; //Field offset: 0x30
		[Nullable(0)]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReaderReadAndAssertAsync>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SkipAsync>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x30
		private int <depth>5__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[NullableContext(0)]
	private enum State
	{
		Start = 0,
		Complete = 1,
		Property = 2,
		ObjectStart = 3,
		Object = 4,
		ArrayStart = 5,
		Array = 6,
		Closed = 7,
		PostValue = 8,
		ConstructorStart = 9,
		Constructor = 10,
		Error = 11,
		Finished = 12,
	}

	private JsonToken _tokenType; //Field offset: 0x10
	private object _value; //Field offset: 0x18
	internal char _quoteChar; //Field offset: 0x20
	internal State _currentState; //Field offset: 0x24
	private JsonPosition _currentPosition; //Field offset: 0x28
	private CultureInfo _culture; //Field offset: 0x40
	private DateTimeZoneHandling _dateTimeZoneHandling; //Field offset: 0x48
	private Nullable _maxDepth; //Field offset: 0x4C
	private bool _hasExceededMaxDepth; //Field offset: 0x54
	internal DateParseHandling _dateParseHandling; //Field offset: 0x58
	internal FloatParseHandling _floatParseHandling; //Field offset: 0x5C
	private string _dateFormatString; //Field offset: 0x60
	private List _stack; //Field offset: 0x68
	[CompilerGenerated]
	private bool <CloseInput>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private bool <SupportMultipleContent>k__BackingField; //Field offset: 0x71

	public bool CloseInput
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	[Nullable(1)]
	public CultureInfo Culture
	{
		[NullableContext(1)]
		 get { } //Length: 89
		[NullableContext(1)]
		 set { } //Length: 82
	}

	protected State CurrentState
	{
		 get { } //Length: 4
	}

	public string DateFormatString
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	public DateParseHandling DateParseHandling
	{
		 get { } //Length: 4
		 set { } //Length: 99
	}

	public DateTimeZoneHandling DateTimeZoneHandling
	{
		 get { } //Length: 4
		 set { } //Length: 99
	}

	public override int Depth
	{
		 get { } //Length: 110
	}

	public FloatParseHandling FloatParseHandling
	{
		 get { } //Length: 4
		 set { } //Length: 99
	}

	public Nullable MaxDepth
	{
		 get { } //Length: 5
		 set { } //Length: 187
	}

	[Nullable(1)]
	public override string Path
	{
		[NullableContext(1)]
		 get { } //Length: 389
	}

	public private override char QuoteChar
	{
		 get { } //Length: 5
		private set { } //Length: 5
	}

	public bool SupportMultipleContent
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override JsonToken TokenType
	{
		 get { } //Length: 164
	}

	public override object Value
	{
		 get { } //Length: 5
	}

	public override Type ValueType
	{
		 get { } //Length: 24
	}

	protected JsonReader() { }

	public override void Close() { }

	[NullableContext(1)]
	internal JsonReaderException CreateUnexpectedEndException() { }

	protected override void Dispose(bool disposing) { }

	[CompilerGenerated]
	public bool get_CloseInput() { }

	[NullableContext(1)]
	public CultureInfo get_Culture() { }

	protected State get_CurrentState() { }

	public string get_DateFormatString() { }

	public DateParseHandling get_DateParseHandling() { }

	public DateTimeZoneHandling get_DateTimeZoneHandling() { }

	public override int get_Depth() { }

	public FloatParseHandling get_FloatParseHandling() { }

	public Nullable get_MaxDepth() { }

	[NullableContext(1)]
	public override string get_Path() { }

	public override char get_QuoteChar() { }

	[CompilerGenerated]
	public bool get_SupportMultipleContent() { }

	public override JsonToken get_TokenType() { }

	public override object get_Value() { }

	public override Type get_ValueType() { }

	private JsonToken GetContentToken() { }

	internal JsonPosition GetPosition(int depth) { }

	private JsonContainerType GetTypeForCloseToken(JsonToken token) { }

	internal bool MoveToContent() { }

	[NullableContext(1)]
	internal Task MoveToContentAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<MoveToContentFromNonContentAsync>d__14))]
	[NullableContext(1)]
	private Task MoveToContentFromNonContentAsync(CancellationToken cancellationToken) { }

	private JsonContainerType Peek() { }

	private JsonContainerType Pop() { }

	private void Push(JsonContainerType value) { }

	public abstract bool Read() { }

	internal void ReadAndAssert() { }

	internal bool ReadAndMoveToContent() { }

	[AsyncStateMachine(typeof(<ReadAndMoveToContentAsync>d__12))]
	[NullableContext(1)]
	internal Task ReadAndMoveToContentAsync(CancellationToken cancellationToken) { }

	[NullableContext(1)]
	private bool ReadArrayElementIntoByteArrayReportDone(List buffer) { }

	[NullableContext(1)]
	internal byte[] ReadArrayIntoByteArray() { }

	[AsyncStateMachine(typeof(<ReadArrayIntoByteArrayAsync>d__5))]
	internal Task ReadArrayIntoByteArrayAsync(CancellationToken cancellationToken) { }

	public override Nullable ReadAsBoolean() { }

	[NullableContext(1)]
	public override Task ReadAsBooleanAsync(CancellationToken cancellationToken = null) { }

	public override byte[] ReadAsBytes() { }

	public override Task ReadAsBytesAsync(CancellationToken cancellationToken = null) { }

	public override Nullable ReadAsDateTime() { }

	[NullableContext(1)]
	public override Task ReadAsDateTimeAsync(CancellationToken cancellationToken = null) { }

	public override Nullable ReadAsDateTimeOffset() { }

	[NullableContext(1)]
	public override Task ReadAsDateTimeOffsetAsync(CancellationToken cancellationToken = null) { }

	public override Nullable ReadAsDecimal() { }

	[NullableContext(1)]
	public override Task ReadAsDecimalAsync(CancellationToken cancellationToken = null) { }

	public override Nullable ReadAsDouble() { }

	[NullableContext(1)]
	public override Task ReadAsDoubleAsync(CancellationToken cancellationToken = null) { }

	public override Nullable ReadAsInt32() { }

	[NullableContext(1)]
	public override Task ReadAsInt32Async(CancellationToken cancellationToken = null) { }

	public override string ReadAsString() { }

	public override Task ReadAsStringAsync(CancellationToken cancellationToken = null) { }

	[NullableContext(1)]
	public override Task ReadAsync(CancellationToken cancellationToken = null) { }

	internal Nullable ReadBooleanString(string s) { }

	internal Nullable ReadDateTimeOffsetString(string s) { }

	internal Nullable ReadDateTimeString(string s) { }

	internal Nullable ReadDecimalString(string s) { }

	internal Nullable ReadDoubleString(string s) { }

	internal void ReaderReadAndAssert() { }

	[AsyncStateMachine(typeof(<ReaderReadAndAssertAsync>d__2))]
	[NullableContext(1)]
	internal Task ReaderReadAndAssertAsync(CancellationToken cancellationToken) { }

	internal bool ReadForType(JsonContract contract, bool hasConverter) { }

	internal void ReadForTypeAndAssert(JsonContract contract, bool hasConverter) { }

	internal Nullable ReadInt32String(string s) { }

	internal void ReadIntoWrappedTypeObject() { }

	[CompilerGenerated]
	public void set_CloseInput(bool value) { }

	[NullableContext(1)]
	public void set_Culture(CultureInfo value) { }

	public void set_DateFormatString(string value) { }

	public void set_DateParseHandling(DateParseHandling value) { }

	public void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	public void set_FloatParseHandling(FloatParseHandling value) { }

	public void set_MaxDepth(Nullable value) { }

	protected private override void set_QuoteChar(char value) { }

	[CompilerGenerated]
	public void set_SupportMultipleContent(bool value) { }

	private void SetFinished() { }

	internal void SetPostValueState(bool updateIndex) { }

	protected void SetStateBasedOnCurrent() { }

	protected void SetToken(JsonToken newToken) { }

	protected void SetToken(JsonToken newToken, object value) { }

	protected void SetToken(JsonToken newToken, object value, bool updateIndex) { }

	public void Skip() { }

	[AsyncStateMachine(typeof(<SkipAsync>d__1))]
	[NullableContext(1)]
	public Task SkipAsync(CancellationToken cancellationToken = null) { }

	private override void System.IDisposable.Dispose() { }

	private void UpdateScopeWithFinishedValue() { }

	private void ValidateEnd(JsonToken endToken) { }

}

