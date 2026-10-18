namespace EFT.Utilities;

public sealed class ClientMetricsCollector : MetricsCollector
{
	[CompilerGenerated]
	private static EPauseReason <PauseReason>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly RenderBinMetricCollector <RenderBinMetricCollector>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private readonly GameUpdateBinMetricCollector <GameUpdateBinMetricCollector>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private readonly EPauseReason <SettingsPauseReason>k__BackingField; //Field offset: 0x60

	public GameUpdateBinMetricCollector GameUpdateBinMetricCollector
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public static bool Paused
	{
		 get { } //Length: 62
	}

	public private static EPauseReason PauseReason
	{
		[CompilerGenerated]
		 get { } //Length: 59
		[CompilerGenerated]
		private set { } //Length: 64
	}

	public RenderBinMetricCollector RenderBinMetricCollector
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public EPauseReason SettingsPauseReason
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ClientMetricsCollector(ClientMetricsConfig metricsConfig, IRaidCounter raidCounter) { }

	[CompilerGenerated]
	public GameUpdateBinMetricCollector get_GameUpdateBinMetricCollector() { }

	public static bool get_Paused() { }

	[CompilerGenerated]
	public static EPauseReason get_PauseReason() { }

	[CompilerGenerated]
	public RenderBinMetricCollector get_RenderBinMetricCollector() { }

	[CompilerGenerated]
	public EPauseReason get_SettingsPauseReason() { }

	private void PauseFrameRelatedMetrics(bool pause) { }

	[CompilerGenerated]
	private static void set_PauseReason(EPauseReason value) { }

	public void TryPauseFrameRelatedMetrics(EPauseReason pauseReason) { }

	public void TryResumeFrameRelatedMetrics(EPauseReason pauseReason) { }

}

