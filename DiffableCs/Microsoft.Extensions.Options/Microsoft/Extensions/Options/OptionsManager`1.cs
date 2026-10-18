namespace Microsoft.Extensions.Options;

[Nullable(0)]
[NullableContext(1)]
public class OptionsManager`1 : IOptions, IOptionsSnapshot
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public IOptionsFactory localFactory; //Field offset: 0x0
		public string localName; //Field offset: 0x0

		public <>c__DisplayClass5_0() { }

		internal TOptions <Get>b__0() { }

	}

	private readonly IOptionsFactory _factory; //Field offset: 0x0
	private readonly OptionsCache _cache; //Field offset: 0x0

	public override TOptions Value
	{
		 get { } //Length: 111
	}

	public OptionsManager`1(IOptionsFactory factory) { }

	public override TOptions Get(string name) { }

	public override TOptions get_Value() { }

}

