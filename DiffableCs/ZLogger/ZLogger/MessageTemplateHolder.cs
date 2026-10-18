namespace ZLogger;

[Nullable(0)]
[NullableContext(1)]
internal sealed class MessageTemplateHolder : IEquatable
{
	[CompilerGenerated]
	private readonly int <LiteralLength>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly int <FormattedCount>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private readonly MessageTemplateChunk[] <TemplateChunk>k__BackingField; //Field offset: 0x18

	[CompilerGenerated]
	private Type EqualityContract
	{
		[CompilerGenerated]
		private get { } //Length: 175
	}

	public int FormattedCount
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public int LiteralLength
	{
		[CompilerGenerated]
		 get { } //Length: 164
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public MessageTemplateChunk[] TemplateChunk
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public MessageTemplateHolder(int LiteralLength, int FormattedCount, MessageTemplateChunk[] TemplateChunk) { }

	[CompilerGenerated]
	private MessageTemplateHolder(MessageTemplateHolder original) { }

	[CompilerGenerated]
	public MessageTemplateHolder <Clone>$() { }

	[CompilerGenerated]
	public void Deconstruct(out int LiteralLength, out int FormattedCount, out MessageTemplateChunk[] TemplateChunk) { }

	[CompilerGenerated]
	[NullableContext(2)]
	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	[NullableContext(2)]
	public override bool Equals(MessageTemplateHolder other) { }

	[CompilerGenerated]
	private Type get_EqualityContract() { }

	[CompilerGenerated]
	public int get_FormattedCount() { }

	[CompilerGenerated]
	public int get_LiteralLength() { }

	[CompilerGenerated]
	public MessageTemplateChunk[] get_TemplateChunk() { }

	[CompilerGenerated]
	public virtual int GetHashCode() { }

	[CompilerGenerated]
	[NullableContext(2)]
	public static bool op_Equality(MessageTemplateHolder left, MessageTemplateHolder right) { }

	[CompilerGenerated]
	[NullableContext(2)]
	public static bool op_Inequality(MessageTemplateHolder left, MessageTemplateHolder right) { }

	[CompilerGenerated]
	private bool PrintMembers(StringBuilder builder) { }

	[CompilerGenerated]
	public void set_FormattedCount(int value) { }

	[CompilerGenerated]
	public void set_LiteralLength(int value) { }

	[CompilerGenerated]
	public void set_TemplateChunk(MessageTemplateChunk[] value) { }

	[CompilerGenerated]
	public virtual string ToString() { }

}

