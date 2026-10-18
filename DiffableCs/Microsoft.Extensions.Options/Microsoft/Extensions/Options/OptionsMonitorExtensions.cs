namespace Microsoft.Extensions.Options;

[Extension]
public static class OptionsMonitorExtensions
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0`1
	{
		public Action listener; //Field offset: 0x0

		public <>c__DisplayClass0_0`1() { }

		internal void <OnChange>b__0(TOptions o, string _) { }

	}


	[Extension]
	[NullableContext(1)]
	public static IDisposable OnChange(IOptionsMonitor monitor, Action listener) { }

}

