namespace Microsoft.Extensions.Options;

[Nullable(0)]
[NullableContext(1)]
internal sealed class UnnamedOptionsManager`1 : IOptions
{
	private readonly IOptionsFactory _factory; //Field offset: 0x0
	private object _syncObj; //Field offset: 0x0
	private TOptions _value; //Field offset: 0x0

	public override TOptions Value
	{
		 get { } //Length: 717
	}

	public UnnamedOptionsManager`1(IOptionsFactory factory) { }

	public override TOptions get_Value() { }

}

