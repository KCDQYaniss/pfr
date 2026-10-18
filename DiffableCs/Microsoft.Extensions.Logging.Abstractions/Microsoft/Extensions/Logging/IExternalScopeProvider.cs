namespace Microsoft.Extensions.Logging;

[NullableContext(1)]
public interface IExternalScopeProvider
{

	public void ForEachScope(Action callback, TState state) { }

	public IDisposable Push(object state) { }

}

