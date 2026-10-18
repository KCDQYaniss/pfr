namespace ZLogger;

internal sealed class MessageSequence
{
	[IsReadOnly]
	private struct LiteralList : IEquatable
	{
		[Nullable(2)]
		[ThreadStatic]
		private static XxHash3 xxhash; //Field offset: 0x80000000
		[Nullable(new IL2CPP_TYPE_U1[] {1, 2})]
		private readonly List literals; //Field offset: 0x0

		public LiteralList(List literals) { }

		public override bool Equals(LiteralList other) { }

		public virtual int GetHashCode() { }

	}

	[Nullable(1)]
	private static readonly ConcurrentDictionary cache; //Field offset: 0x0
	private readonly int literalLength; //Field offset: 0x10
	private readonly int parametersLength; //Field offset: 0x14
	[Nullable(1)]
	private readonly MessageSequenceSegment[] segments; //Field offset: 0x18

	private static MessageSequence() { }

	public MessageSequence(int literalLength, int parametersLength, ReadOnlySpan literals) { }

	[NullableContext(1)]
	public static MessageSequence GetOrCreate(int literalLength, int parameterLength, List literals) { }

	public string GetOriginalFormat(Span parameters) { }

	public void ToString(IBufferWriter writer, MagicalBox box, Span parameters) { }

	public string ToString(MagicalBox box, Span parameters) { }

	[NullableContext(1)]
	public virtual string ToString() { }

	public void WriteOriginalFormat(IBufferWriter writer, Span parameters) { }

}

