namespace ZLogger;

[InterpolatedStringHandler]
[Nullable(0)]
[NullableContext(1)]
public struct MessageTemplateHandler
{
	[CompilerGenerated]
	private int <literalLength>P; //Field offset: 0x0
	[CompilerGenerated]
	private int <formattedCount>P; //Field offset: 0x4
	private readonly List templateChunk; //Field offset: 0x8

	public MessageTemplateHandler(int literalLength, int formattedCount) { }

	[NullableContext(2)]
	public void AppendFormatted(int index, int alignment = 0, string format = null) { }

	public void AppendLiteral(string s) { }

	internal MessageTemplateHolder GetTemplate() { }

}

