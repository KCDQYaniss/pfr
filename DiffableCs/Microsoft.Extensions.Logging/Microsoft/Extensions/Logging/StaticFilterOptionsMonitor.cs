namespace Microsoft.Extensions.Logging;

internal sealed class StaticFilterOptionsMonitor : IOptionsMonitor
{
	[CompilerGenerated]
	private readonly LoggerFilterOptions <CurrentValue>k__BackingField; //Field offset: 0x10

	public override LoggerFilterOptions CurrentValue
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public StaticFilterOptionsMonitor(LoggerFilterOptions currentValue) { }

	[CompilerGenerated]
	public override LoggerFilterOptions get_CurrentValue() { }

	public override IDisposable OnChange(Action listener) { }

}

