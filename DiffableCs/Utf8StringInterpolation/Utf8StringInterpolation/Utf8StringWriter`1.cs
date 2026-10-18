namespace Utf8StringInterpolation;

[CompilerFeatureRequired("RefStructs")]
[InterpolatedStringHandler]
[IsByRefLike]
[Nullable(0)]
[NullableContext(2)]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
public struct Utf8StringWriter`1
{
	[Nullable(1)]
	private static readonly byte[] NewLineUtf8Bytes; //Field offset: 0x0
	private const int DefaultInitialSize = 256; //Field offset: 0x0
	private const int GuessedLengthPerHole = 11; //Field offset: 0x0
	[Nullable(0)]
	private Span destination; //Field offset: 0x0
	private int allocatedDestinationSize; //Field offset: 0x0
	[Nullable(1)]
	private TBufferWriter bufferWriter; //Field offset: 0x0
	private int currentWritten; //Field offset: 0x0
	private IFormatProvider formatProvider; //Field offset: 0x0
	private bool calculateStringJustSize; //Field offset: 0x0

	private static Utf8StringWriter`1() { }

	[NullableContext(1)]
	public Utf8StringWriter`1(TBufferWriter bufferWriter, IFormatProvider formatProvider = null) { }

	[NullableContext(1)]
	public Utf8StringWriter`1(int literalLength, int formattedCount, TBufferWriter bufferWriter, IFormatProvider formatProvider = null) { }

	public Utf8StringWriter`1(int literalLength, int formattedCount, IFormatProvider formatProvider = null) { }

	[NullableContext(0)]
	public Utf8StringWriter`1(int literalLength, int formattedCount, Span destination, IFormatProvider formatProvider = null) { }

	public Utf8StringWriter`1(int literalLength, int formattedCount, ref Utf8StringWriter parent) { }

	public void Append(char c) { }

	public void Append(string s) { }

	public void Append(char c, int repeatCount) { }

	public void AppendFormatted(Nullable value, int alignment = 0, string format = null) { }

	public void AppendFormatted(Nullable value, int alignment = 0, string format = null) { }

	public void AppendFormatted(uint value, int alignment = 0, string format = null) { }

	public void AppendFormatted(Nullable value, int alignment = 0, string format = null) { }

	public void AppendFormatted(ushort value, int alignment = 0, string format = null) { }

	public void AppendFormatted(ulong value, int alignment = 0, string format = null) { }

	public void AppendFormatted(Nullable value, int alignment = 0, string format = null) { }

	public void AppendFormatted(DateTimeOffset value, int alignment = 0, string format = null) { }

	public void AppendFormatted(T value, int alignment = 0, string format = null) { }

	public void AppendFormatted(TimeSpan value, int alignment = 0, string format = null) { }

	public void AppendFormatted(Nullable value, int alignment = 0, string format = null) { }

	public void AppendFormatted(char value, int alignment = 0, string format = null) { }

	public void AppendFormatted(Nullable value, int alignment = 0, string format = null) { }

	[NullableContext(0)]
	public void AppendFormatted(ReadOnlySpan utf8String) { }

	[NullableContext(0)]
	public void AppendFormatted(ReadOnlySpan s) { }

	[NullableContext(1)]
	public void AppendFormatted(string value, int alignment = 0, string format = null) { }

	[NullableContext(0)]
	public void AppendFormatted(Nullable value, int alignment = 0, string format = null) { }

	public void AppendFormatted(Nullable value, int alignment = 0, string format = null) { }

	public void AppendFormatted(float value, int alignment = 0, string format = null) { }

	public void AppendFormatted(DateTime value, int alignment = 0, string format = null) { }

	public void AppendFormatted(Nullable value, int alignment = 0, string format = null) { }

	public void AppendFormatted(Nullable value, int alignment = 0, string format = null) { }

	public void AppendFormatted(Nullable value, int alignment = 0, string format = null) { }

	public void AppendFormatted(short value, int alignment = 0, string format = null) { }

	public void AppendFormatted(double value, int alignment = 0, string format = null) { }

	public void AppendFormatted(Nullable value, int alignment = 0, string format = null) { }

	public void AppendFormatted(Nullable value, int alignment = 0, string format = null) { }

	public void AppendFormatted(int value, int alignment = 0, string format = null) { }

	public void AppendFormatted(Nullable value, int alignment = 0, string format = null) { }

	public void AppendFormatted(Nullable value, int alignment = 0, string format = null) { }

	public void AppendFormatted(decimal value, int alignment = 0, string format = null) { }

	public void AppendFormatted(Nullable value, int alignment = 0, string format = null) { }

	public void AppendFormatted(long value, int alignment = 0, string format = null) { }

	public void AppendFormatted(byte value, int alignment = 0, string format = null) { }

	public void AppendFormatted(Nullable value, int alignment = 0, string format = null) { }

	public void AppendFormatted(Nullable value, int alignment = 0, string format = null) { }

	public void AppendFormatted(sbyte value, int alignment = 0, string format = null) { }

	public void AppendFormatted(bool value, int alignment = 0, string format = null) { }

	public void AppendFormatted(Guid value, int alignment = 0, string format = null) { }

	private void AppendFormattedAlignment(decimal value, int alignment, string format) { }

	private void AppendFormattedAlignment(bool value, int alignment, string format) { }

	private void AppendFormattedAlignment(double value, int alignment, string format) { }

	private void AppendFormattedAlignment(byte value, int alignment, string format) { }

	private void AppendFormattedAlignment(float value, int alignment, string format) { }

	private void AppendFormattedAlignment(uint value, int alignment, string format) { }

	private void AppendFormattedAlignment(sbyte value, int alignment, string format) { }

	private void AppendFormattedAlignment(ushort value, int alignment, string format) { }

	private void AppendFormattedAlignment(long value, int alignment, string format) { }

	private void AppendFormattedAlignment(ulong value, int alignment, string format) { }

	private void AppendFormattedAlignment(DateTime value, int alignment, string format) { }

	private void AppendFormattedAlignment(int value, int alignment, string format) { }

	private void AppendFormattedAlignment(short value, int alignment, string format) { }

	private void AppendFormattedAlignment(TimeSpan value, int alignment, string format) { }

	private void AppendFormattedAlignment(Guid value, int alignment, string format) { }

	private void AppendFormattedAlignment(char value, int alignment, string format) { }

	private void AppendFormattedAlignment(DateTimeOffset value, int alignment, string format) { }

	private void AppendFormattedCore(T value, int alignment = 0, string format = null) { }

	[NullableContext(1)]
	public void AppendLine(string s) { }

	public void AppendLine() { }

	[NullableContext(1)]
	public void AppendLiteral(string s) { }

	[NullableContext(0)]
	private int AppendString(ReadOnlySpan s) { }

	[NullableContext(0)]
	public void AppendUtf8(ReadOnlySpan utf8String) { }

	public void AppendWhitespace(int count) { }

	public void ClearState() { }

	public void Dispose() { }

	public void Flush() { }

	public int GetAllocatedDestinationSize() { }

	[NullableContext(1)]
	public TBufferWriter GetBufferWriter() { }

	public int GetCurrentWritten() { }

	[NullableContext(0)]
	private int GetStringByteCount(ReadOnlySpan str) { }

	private void GrowCore(int len) { }

	public void TryGrow(int len) { }

}

