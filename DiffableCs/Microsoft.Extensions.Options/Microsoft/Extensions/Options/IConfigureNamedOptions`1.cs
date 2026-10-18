namespace Microsoft.Extensions.Options;

[NullableContext(1)]
public interface IConfigureNamedOptions`1 : IConfigureOptions
{

	public void Configure(string name, TOptions options) { }

}

