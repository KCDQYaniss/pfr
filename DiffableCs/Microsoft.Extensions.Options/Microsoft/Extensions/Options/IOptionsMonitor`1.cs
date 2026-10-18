namespace Microsoft.Extensions.Options;

[NullableContext(1)]
public interface IOptionsMonitor`1
{

	public TOptions CurrentValue
	{
		 get { } //Length: 0
	}

	public TOptions get_CurrentValue() { }

	[NullableContext(2)]
	public IDisposable OnChange(Action listener) { }

}

