namespace ZLogger;

[IsReadOnly]
[Nullable(0)]
[NullableContext(2)]
internal struct MessageTemplateChunk : IEquatable
{
	[CompilerGenerated]
	private readonly byte[] <Literal>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly int <Index>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private readonly int <Alignment>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private readonly string <Format>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly bool <NoAlignmentAndFormat>k__BackingField; //Field offset: 0x18

	public int Alignment
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public string Format
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public int Index
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public byte[] Literal
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public bool NoAlignmentAndFormat
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public MessageTemplateChunk(byte[] Literal, int Index, int Alignment, string Format, bool NoAlignmentAndFormat) { }

	[CompilerGenerated]
	public void Deconstruct(out byte[] Literal, out int Index, out int Alignment, out string Format, out bool NoAlignmentAndFormat) { }

	[CompilerGenerated]
	public override bool Equals(MessageTemplateChunk other) { }

	[CompilerGenerated]
	[NullableContext(0)]
	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	public int get_Alignment() { }

	[CompilerGenerated]
	public string get_Format() { }

	[CompilerGenerated]
	public int get_Index() { }

	[CompilerGenerated]
	public byte[] get_Literal() { }

	[CompilerGenerated]
	public bool get_NoAlignmentAndFormat() { }

	[CompilerGenerated]
	public virtual int GetHashCode() { }

	[CompilerGenerated]
	public static bool op_Equality(MessageTemplateChunk left, MessageTemplateChunk right) { }

	[CompilerGenerated]
	public static bool op_Inequality(MessageTemplateChunk left, MessageTemplateChunk right) { }

	[CompilerGenerated]
	[NullableContext(0)]
	private bool PrintMembers(StringBuilder builder) { }

	[CompilerGenerated]
	public void set_Alignment(int value) { }

	[CompilerGenerated]
	public void set_Format(string value) { }

	[CompilerGenerated]
	public void set_Index(int value) { }

	[CompilerGenerated]
	public void set_Literal(byte[] value) { }

	[CompilerGenerated]
	public void set_NoAlignmentAndFormat(bool value) { }

	[CompilerGenerated]
	[NullableContext(0)]
	public virtual string ToString() { }

}

