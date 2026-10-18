namespace ZLogger;

[NullableContext(1)]
public interface IZLoggerFormatter
{

	public bool WithLineBreak
	{
		 get { } //Length: 0
	}

	public void FormatLogEntry(IBufferWriter writer, IZLoggerEntry entry) { }

	public bool get_WithLineBreak() { }

}

