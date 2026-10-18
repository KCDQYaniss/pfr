namespace ZLogger;

public interface IZLoggerEntry : INonReturnableZLoggerEntry, IZLoggerFormattable, IZLoggerEntryCreatable
{

	public void Return() { }

}

