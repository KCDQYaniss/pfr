namespace ZLogger;

public interface INonReturnableZLoggerEntry : IZLoggerFormattable, IZLoggerEntryCreatable
{

	public LogInfo LogInfo
	{
		 get { } //Length: 0
	}

	[NullableContext(1)]
	public void FormatUtf8(IBufferWriter writer, IZLoggerFormatter formatter) { }

	public LogInfo get_LogInfo() { }

}

