namespace System.Collections.Generic;

public interface IAsyncEnumerator`1 : IAsyncDisposable
{

	public T Current
	{
		 get { } //Length: 0
	}

	public T get_Current() { }

	public ValueTask MoveNextAsync() { }

}

