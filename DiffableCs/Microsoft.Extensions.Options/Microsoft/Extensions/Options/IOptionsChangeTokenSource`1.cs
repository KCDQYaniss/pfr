namespace Microsoft.Extensions.Options;

[NullableContext(2)]
public interface IOptionsChangeTokenSource`1
{

	public string Name
	{
		 get { } //Length: 0
	}

	public string get_Name() { }

	[NullableContext(1)]
	public IChangeToken GetChangeToken() { }

}

