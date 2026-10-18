namespace ZLogger.Formatters;

[Nullable(0)]
[NullableContext(1)]
public class PlainTextZLoggerFormatter : IZLoggerFormatter
{
	[CompilerGenerated]
	private static class <>O
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 1})]
		public static Action <0>__DefaultExceptionLoggingFormatter; //Field offset: 0x0

	}

	private static readonly byte[] newLine; //Field offset: 0x0
	private Action exceptionFormatter; //Field offset: 0x10
	[Nullable(2)]
	private MessageTemplateHolder prefixTemplate; //Field offset: 0x18
	[Nullable(2)]
	private MessageTemplateFormatter prefixFormatter; //Field offset: 0x20
	[Nullable(2)]
	private MessageTemplateHolder suffixTemplate; //Field offset: 0x28
	[Nullable(2)]
	private MessageTemplateFormatter suffixFormatter; //Field offset: 0x30

	public override bool WithLineBreak
	{
		 get { } //Length: 3
	}

	private static PlainTextZLoggerFormatter() { }

	public PlainTextZLoggerFormatter() { }

	private static void DefaultExceptionLoggingFormatter(IBufferWriter writer, Exception exception) { }

	public override void FormatLogEntry(IBufferWriter writer, IZLoggerEntry entry) { }

	public override bool get_WithLineBreak() { }

	public void SetExceptionFormatter(Action formatter) { }

	public void SetPrefixFormatter(MessageTemplateHandler format, MessageTemplateFormatter formatter) { }

	public void SetSuffixFormatter(MessageTemplateHandler format, MessageTemplateFormatter formatter) { }

	[NullableContext(0)]
	private static void Write(IBufferWriter writer, ReadOnlySpan value) { }

	private static void Write(IBufferWriter writer, ReadOnlySpan message1, string message2) { }

	private static void Write(IBufferWriter writer, string message1, string message2, string message3) { }

	private static void WriteExceptionLoggingCore(IBufferWriter writer, Exception exception) { }

}

