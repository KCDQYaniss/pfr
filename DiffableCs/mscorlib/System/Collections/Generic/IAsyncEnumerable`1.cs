namespace System.Collections.Generic;

public interface IAsyncEnumerable`1
{

	public IAsyncEnumerator GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

