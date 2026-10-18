namespace System.Runtime.CompilerServices;

[CompilerFeatureRequired("RefStructs")]
[InterpolatedStringHandler]
[IsByRefLike]
[Nullable(0)]
[NullableContext(2)]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
internal struct DefaultInterpolatedStringHandler
{
	private const int GuessedLengthPerHole = 11; //Field offset: 0x0
	private const int MinimumArrayPoolLength = 256; //Field offset: 0x0
	private readonly IFormatProvider _provider; //Field offset: 0x0
	private char[] _arrayToReturnToPool; //Field offset: 0x8
	[Nullable(0)]
	private Span _chars; //Field offset: 0x10
	private int _pos; //Field offset: 0x20
	private readonly bool _hasCustomFormatter; //Field offset: 0x24

	[Nullable(0)]
	internal ReadOnlySpan Text
	{
		[NullableContext(0)]
		internal get { } //Length: 184
	}

	public DefaultInterpolatedStringHandler(int literalLength, int formattedCount) { }

	public DefaultInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider provider) { }

	[NullableContext(0)]
	public DefaultInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider provider, Span initialBuffer) { }

	private void AppendCustomFormatter(T value, string format) { }

	public void AppendFormatted(object value, int alignment = 0, string format = null) { }

	public void AppendFormatted(string value, int alignment = 0, string format = null) { }

	public void AppendFormatted(string value) { }

	[NullableContext(0)]
	public void AppendFormatted(ReadOnlySpan value, int alignment = 0, string format = null) { }

	public void AppendFormatted(T value, int alignment, string format) { }

	[NullableContext(1)]
	public void AppendFormatted(T value, int alignment) { }

	[NullableContext(0)]
	public void AppendFormatted(ReadOnlySpan value) { }

	[NullableContext(1)]
	public void AppendFormatted(T value) { }

	public void AppendFormatted(T value, string format) { }

	private void AppendFormattedSlow(string value) { }

	[NullableContext(1)]
	public void AppendLiteral(string value) { }

	private void AppendOrInsertAlignmentIfNeeded(int startingPos, int alignment) { }

	internal void Clear() { }

	private void EnsureCapacityForAdditionalChars(int additionalChars) { }

	[NullableContext(0)]
	internal ReadOnlySpan get_Text() { }

	internal static int GetDefaultLength(int literalLength, int formattedCount) { }

	private void Grow() { }

	private void Grow(int additionalChars) { }

	private void GrowCore(uint requiredMinCapacity) { }

	[NullableContext(0)]
	private void GrowThenCopySpan(ReadOnlySpan value) { }

	[NullableContext(1)]
	private void GrowThenCopyString(string value) { }

	[NullableContext(1)]
	internal static bool HasCustomFormatter(IFormatProvider provider) { }

	[NullableContext(1)]
	public virtual string ToString() { }

	[NullableContext(1)]
	public string ToStringAndClear() { }

}

