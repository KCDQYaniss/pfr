namespace ZLogger;

public interface IAsyncLogProcessor : IAsyncDisposable
{

	[NullableContext(1)]
	public void Post(IZLoggerEntry log) { }

}

