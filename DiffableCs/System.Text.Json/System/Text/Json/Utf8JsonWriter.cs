namespace System.Text.Json;

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public sealed class Utf8JsonWriter : IDisposable, IAsyncDisposable
{
	[CompilerGenerated]
	private struct <DisposeAsync>d__42 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncValueTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Utf8JsonWriter <>4__this; //Field offset: 0x28
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <FlushAsync>d__43 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Utf8JsonWriter <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static readonly int s_newLineLength; //Field offset: 0x0
	private static readonly char[] s_singleLineCommentDelimiter; //Field offset: 0x8
	private IBufferWriter _output; //Field offset: 0x10
	private Stream _stream; //Field offset: 0x18
	private ArrayBufferWriter _arrayBufferWriter; //Field offset: 0x20
	private Memory _memory; //Field offset: 0x28
	private bool _inObject; //Field offset: 0x38
	private bool _commentAfterNoneOrPropertyName; //Field offset: 0x39
	private JsonTokenType _tokenType; //Field offset: 0x3A
	private BitStack _bitStack; //Field offset: 0x40
	private int _currentDepth; //Field offset: 0x58
	private JsonWriterOptions _options; //Field offset: 0x60
	[CompilerGenerated]
	private int <BytesPending>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private long <BytesCommitted>k__BackingField; //Field offset: 0x78

	public private long BytesCommitted
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private int BytesPending
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public int CurrentDepth
	{
		 get { } //Length: 8
	}

	private int Indentation
	{
		private get { } //Length: 6
	}

	internal JsonTokenType TokenType
	{
		internal get { } //Length: 5
	}

	private static Utf8JsonWriter() { }

	private Utf8JsonWriter() { }

	[NullableContext(1)]
	public Utf8JsonWriter(IBufferWriter bufferWriter, JsonWriterOptions options = null) { }

	private void Base64EncodeAndWrite(ReadOnlySpan bytes, Span output, int encodingLength) { }

	private void CheckNotDisposed() { }

	internal static Utf8JsonWriter CreateEmptyInstanceForCaching() { }

	public override void Dispose() { }

	[AsyncStateMachine(typeof(<DisposeAsync>d__42))]
	public override ValueTask DisposeAsync() { }

	private void FirstCallToGetMemory(int requiredSize) { }

	public void Flush() { }

	[AsyncStateMachine(typeof(<FlushAsync>d__43))]
	[NullableContext(1)]
	public Task FlushAsync(CancellationToken cancellationToken = null) { }

	[CompilerGenerated]
	public long get_BytesCommitted() { }

	[CompilerGenerated]
	public int get_BytesPending() { }

	public int get_CurrentDepth() { }

	private int get_Indentation() { }

	internal JsonTokenType get_TokenType() { }

	private void Grow(int requiredSize) { }

	[NullableContext(1)]
	public void Reset(IBufferWriter bufferWriter) { }

	public void Reset() { }

	internal void Reset(IBufferWriter bufferWriter, JsonWriterOptions options) { }

	internal void ResetAllStateForCacheReuse() { }

	private void ResetHelper() { }

	[CompilerGenerated]
	private void set_BytesCommitted(long value) { }

	[CompilerGenerated]
	private void set_BytesPending(int value) { }

	private void SetFlagToAddListSeparatorBeforeNextItem() { }

	private void TranscodeAndWrite(ReadOnlySpan escapedPropertyName, Span output) { }

	private static bool TryFormatDouble(double value, Span destination, out int bytesWritten) { }

	private static bool TryFormatSingle(float value, Span destination, out int bytesWritten) { }

	private void UpdateBitStackOnStart(byte token) { }

	private void ValidateDepth() { }

	private void ValidateEnd(byte token) { }

	private void ValidateStart() { }

	private void ValidateWritingProperty() { }

	private void ValidateWritingProperty(byte token) { }

	private void ValidateWritingValue() { }

	private void WriteBase64ByOptions(ReadOnlySpan bytes) { }

	private void WriteBase64Indented(ReadOnlySpan bytes) { }

	private void WriteBase64Minimized(ReadOnlySpan bytes) { }

	public void WriteBase64StringValue(ReadOnlySpan bytes) { }

	public void WriteBooleanValue(bool value) { }

	private void WriteEnd(byte token) { }

	public void WriteEndArray() { }

	private void WriteEndIndented(byte token) { }

	private void WriteEndMinimized(byte token) { }

	public void WriteEndObject() { }

	private void WriteEndSlow(byte token) { }

	internal void WriteFloatingPointConstant(double value) { }

	internal void WriteFloatingPointConstant(float value) { }

	private void WriteLiteralByOptions(ReadOnlySpan utf8Value) { }

	private void WriteLiteralByOptions(ReadOnlySpan utf8PropertyName, ReadOnlySpan value) { }

	private void WriteLiteralHelper(ReadOnlySpan utf8PropertyName, ReadOnlySpan value) { }

	private void WriteLiteralIndented(ReadOnlySpan utf8Value) { }

	private void WriteLiteralIndented(ReadOnlySpan escapedPropertyName, ReadOnlySpan value) { }

	private void WriteLiteralMinimized(ReadOnlySpan utf8Value) { }

	private void WriteLiteralMinimized(ReadOnlySpan escapedPropertyName, ReadOnlySpan value) { }

	private void WriteLiteralSection(ReadOnlySpan escapedPropertyNameSection, ReadOnlySpan value) { }

	private void WriteNewLine(Span output) { }

	public void WriteNull(JsonEncodedText propertyName) { }

	internal void WriteNullSection(ReadOnlySpan escapedPropertyNameSection) { }

	public void WriteNullValue() { }

	public void WriteNumber(JsonEncodedText propertyName, int value) { }

	public void WriteNumber(JsonEncodedText propertyName, long value) { }

	private void WriteNumberByOptions(ReadOnlySpan utf8PropertyName, long value) { }

	private void WriteNumberIndented(ReadOnlySpan escapedPropertyName, long value) { }

	private void WriteNumberMinimized(ReadOnlySpan escapedPropertyName, long value) { }

	[CLSCompliant(False)]
	public void WriteNumberValue(ulong value) { }

	public void WriteNumberValue(decimal value) { }

	public void WriteNumberValue(double value) { }

	public void WriteNumberValue(float value) { }

	internal void WriteNumberValue(ReadOnlySpan utf8FormattedNumber) { }

	[CLSCompliant(False)]
	public void WriteNumberValue(uint value) { }

	public void WriteNumberValue(int value) { }

	public void WriteNumberValue(long value) { }

	internal void WriteNumberValueAsString(double value) { }

	internal void WriteNumberValueAsString(float value) { }

	internal void WriteNumberValueAsString(ulong value) { }

	internal void WriteNumberValueAsString(long value) { }

	internal void WriteNumberValueAsString(decimal value) { }

	internal void WriteNumberValueAsStringUnescaped(ReadOnlySpan utf8Value) { }

	private void WriteNumberValueIndented(decimal value) { }

	private void WriteNumberValueIndented(float value) { }

	private void WriteNumberValueIndented(ReadOnlySpan utf8Value) { }

	private void WriteNumberValueIndented(double value) { }

	private void WriteNumberValueIndented(ulong value) { }

	private void WriteNumberValueIndented(long value) { }

	private void WriteNumberValueMinimized(long value) { }

	private void WriteNumberValueMinimized(float value) { }

	private void WriteNumberValueMinimized(double value) { }

	private void WriteNumberValueMinimized(ulong value) { }

	private void WriteNumberValueMinimized(decimal value) { }

	private void WriteNumberValueMinimized(ReadOnlySpan utf8Value) { }

	internal void WritePropertyName(ulong value) { }

	internal void WritePropertyName(uint value) { }

	[NullableContext(1)]
	public void WritePropertyName(string propertyName) { }

	internal void WritePropertyName(double value) { }

	public void WritePropertyName(ReadOnlySpan propertyName) { }

	internal void WritePropertyName(int value) { }

	internal void WritePropertyName(bool value) { }

	internal void WritePropertyName(DateTime value) { }

	public void WritePropertyName(ReadOnlySpan utf8PropertyName) { }

	internal void WritePropertyName(long value) { }

	internal void WritePropertyName(DateTimeOffset value) { }

	internal void WritePropertyName(decimal value) { }

	public void WritePropertyName(JsonEncodedText propertyName) { }

	internal void WritePropertyName(Guid value) { }

	internal void WritePropertyName(float value) { }

	private void WritePropertyNameHelper(ReadOnlySpan utf8PropertyName) { }

	private void WritePropertyNameIndented(ReadOnlySpan escapedPropertyName, byte token) { }

	private void WritePropertyNameMinimized(ReadOnlySpan escapedPropertyName, byte token) { }

	internal void WritePropertyNameSection(ReadOnlySpan escapedPropertyNameSection) { }

	private void WritePropertyNameUnescaped(ReadOnlySpan utf8PropertyName) { }

	private void WriteStart(byte token) { }

	public void WriteStartArray() { }

	private void WriteStartByOptions(ReadOnlySpan utf8PropertyName, byte token) { }

	private void WriteStartHelper(ReadOnlySpan utf8PropertyName, byte token) { }

	private void WriteStartIndented(byte token) { }

	private void WriteStartMinimized(byte token) { }

	public void WriteStartObject() { }

	public void WriteStartObject(JsonEncodedText propertyName) { }

	private void WriteStartSlow(byte token) { }

	[NullableContext(2)]
	public void WriteString(JsonEncodedText propertyName, string value) { }

	public void WriteString(JsonEncodedText propertyName, DateTimeOffset value) { }

	public void WriteString(JsonEncodedText propertyName, JsonEncodedText value) { }

	public void WriteString(JsonEncodedText propertyName, ReadOnlySpan value) { }

	public void WriteString(JsonEncodedText propertyName, ReadOnlySpan utf8Value) { }

	private void WriteStringByOptions(ReadOnlySpan value) { }

	private void WriteStringByOptions(ReadOnlySpan utf8PropertyName, DateTimeOffset value) { }

	private void WriteStringByOptions(ReadOnlySpan utf8Value) { }

	private void WriteStringByOptions(ReadOnlySpan utf8PropertyName, ReadOnlySpan utf8Value) { }

	private void WriteStringByOptions(ReadOnlySpan utf8PropertyName, ReadOnlySpan value) { }

	private void WriteStringByOptionsPropertyName(ReadOnlySpan propertyName) { }

	private void WriteStringByOptionsPropertyName(ReadOnlySpan utf8PropertyName) { }

	private void WriteStringEscape(ReadOnlySpan value) { }

	private void WriteStringEscape(ReadOnlySpan utf8Value) { }

	private void WriteStringEscapeProperty(ReadOnlySpan propertyName, int firstEscapeIndexProp) { }

	private void WriteStringEscapeProperty(ReadOnlySpan utf8PropertyName, int firstEscapeIndexProp) { }

	private void WriteStringEscapeValue(ReadOnlySpan utf8Value, int firstEscapeIndexVal) { }

	private void WriteStringEscapeValue(ReadOnlySpan value, int firstEscapeIndexVal) { }

	private void WriteStringEscapeValueOnly(ReadOnlySpan escapedPropertyName, ReadOnlySpan value, int firstEscapeIndex) { }

	private void WriteStringEscapeValueOnly(ReadOnlySpan escapedPropertyName, ReadOnlySpan utf8Value, int firstEscapeIndex) { }

	private void WriteStringHelper(ReadOnlySpan utf8PropertyName, ReadOnlySpan utf8Value) { }

	private void WriteStringHelperEscapeValue(ReadOnlySpan utf8PropertyName, ReadOnlySpan utf8Value) { }

	private void WriteStringHelperEscapeValue(ReadOnlySpan utf8PropertyName, ReadOnlySpan value) { }

	private void WriteStringIndented(ReadOnlySpan escapedValue) { }

	private void WriteStringIndented(ReadOnlySpan escapedPropertyName, DateTimeOffset value) { }

	private void WriteStringIndented(ReadOnlySpan escapedValue) { }

	private void WriteStringIndented(ReadOnlySpan escapedPropertyName, ReadOnlySpan escapedValue) { }

	private void WriteStringIndented(ReadOnlySpan escapedPropertyName, ReadOnlySpan escapedValue) { }

	private void WriteStringIndentedPropertyName(ReadOnlySpan escapedPropertyName) { }

	private void WriteStringIndentedPropertyName(ReadOnlySpan escapedPropertyName) { }

	private void WriteStringMinimized(ReadOnlySpan escapedPropertyName, ReadOnlySpan escapedValue) { }

	private void WriteStringMinimized(ReadOnlySpan escapedPropertyName, DateTimeOffset value) { }

	private void WriteStringMinimized(ReadOnlySpan escapedPropertyName, ReadOnlySpan escapedValue) { }

	private void WriteStringMinimized(ReadOnlySpan escapedValue) { }

	private void WriteStringMinimized(ReadOnlySpan escapedValue) { }

	private void WriteStringMinimizedPropertyName(ReadOnlySpan escapedPropertyName) { }

	private void WriteStringMinimizedPropertyName(ReadOnlySpan escapedPropertyName) { }

	private void WriteStringPropertyNameSection(ReadOnlySpan escapedPropertyNameSection) { }

	[NullableContext(2)]
	public void WriteStringValue(string value) { }

	public void WriteStringValue(JsonEncodedText value) { }

	public void WriteStringValue(ReadOnlySpan utf8Value) { }

	public void WriteStringValue(Guid value) { }

	public void WriteStringValue(DateTime value) { }

	public void WriteStringValue(DateTimeOffset value) { }

	public void WriteStringValue(ReadOnlySpan value) { }

	private void WriteStringValueIndented(DateTimeOffset value) { }

	private void WriteStringValueIndented(Guid value) { }

	private void WriteStringValueIndented(DateTime value) { }

	private void WriteStringValueMinimized(Guid value) { }

	private void WriteStringValueMinimized(DateTime value) { }

	private void WriteStringValueMinimized(DateTimeOffset value) { }

}

