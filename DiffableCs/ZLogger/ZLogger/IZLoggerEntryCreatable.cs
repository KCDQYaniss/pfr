namespace ZLogger;

[NullableContext(1)]
public interface IZLoggerEntryCreatable
{

	public IZLoggerEntry CreateEntry(in LogInfo info) { }

}

