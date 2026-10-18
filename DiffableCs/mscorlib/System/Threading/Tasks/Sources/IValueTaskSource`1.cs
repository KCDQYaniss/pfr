namespace System.Threading.Tasks.Sources;

public interface IValueTaskSource`1
{

	public TResult GetResult(short token) { }

	public ValueTaskSourceStatus GetStatus(short token) { }

	public void OnCompleted(Action continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags) { }

}

