namespace Microsoft.Extensions.Options;

[NullableContext(1)]
public interface IOptionsMonitorCache`1
{

	public TOptions GetOrAdd(string name, Func createOptions) { }

	[NullableContext(2)]
	public bool TryRemove(string name) { }

}

