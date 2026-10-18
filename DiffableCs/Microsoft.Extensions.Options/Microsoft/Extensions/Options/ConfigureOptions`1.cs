namespace Microsoft.Extensions.Options;

[Nullable(0)]
[NullableContext(1)]
public class ConfigureOptions`1 : IConfigureOptions
{
	[CompilerGenerated]
	private readonly Action <Action>k__BackingField; //Field offset: 0x0

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	public Action Action
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ConfigureOptions`1(Action action) { }

	public override void Configure(TOptions options) { }

	[CompilerGenerated]
	public Action get_Action() { }

}

