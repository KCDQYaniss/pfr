namespace Microsoft.Extensions.Options;

[NullableContext(1)]
public interface IPostConfigureOptions`1
{

	public void PostConfigure(string name, TOptions options) { }

}

