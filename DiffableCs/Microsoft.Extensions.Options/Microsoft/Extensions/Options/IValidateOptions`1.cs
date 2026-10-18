namespace Microsoft.Extensions.Options;

[NullableContext(1)]
public interface IValidateOptions`1
{

	public ValidateOptionsResult Validate(string name, TOptions options) { }

}

