namespace Microsoft.Extensions.Options;

[Nullable(0)]
[NullableContext(1)]
public class OptionsFactory`1 : IOptionsFactory
{
	private readonly IConfigureOptions[] _setups; //Field offset: 0x0
	private readonly IPostConfigureOptions[] _postConfigures; //Field offset: 0x0
	private readonly IValidateOptions[] _validations; //Field offset: 0x0

	public OptionsFactory`1(IEnumerable setups, IEnumerable postConfigures) { }

	public OptionsFactory`1(IEnumerable setups, IEnumerable postConfigures, IEnumerable validations) { }

	public override TOptions Create(string name) { }

	protected override TOptions CreateInstance(string name) { }

}

