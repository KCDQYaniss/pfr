namespace EFT;

internal sealed class EftNetworkGame : CommonNetworkGame
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public ReconnectionScreenController reconnectionScreenController; //Field offset: 0x10
		public EftNetworkGame <>4__this; //Field offset: 0x18

		public <>c__DisplayClass6_0() { }

		internal void <NetworkLeaveGame>b__0() { }

	}

	[CompilerGenerated]
	private struct <ApplyCoopSetting>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftNetworkGame <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private RaidSettings _raidSettings; //Field offset: 0x218

	public bool CoopEnabled
	{
		 get { } //Length: 11
	}

	public EftNetworkGame() { }

	[AsyncStateMachine(typeof(<ApplyCoopSetting>d__9))]
	protected virtual Task ApplyCoopSetting() { }

	protected virtual void CloseScreensForced() { }

	public static EftNetworkGame Create(IEftSession session, ClientGameWorld gameWorld, ProfileStatus profileStatus, RaidSettings raidSettings, Profile savageProfile, InsuranceCompany insurance, IInputTree inputTree, GameUI gameUI, ClientMetricsEvents metricsEvents, ClientMetricsCollector metricsCollector, EUpdateQueue updateQueue, TimeSpan sessionTime, Action runCallback, Callback callback) { }

	public virtual void GameStarted(float pastTime, int sessionSeconds) { }

	public bool get_CoopEnabled() { }

	protected virtual void ModifyMetabolism(Player player) { }

	private void ModifyWeather() { }

	protected virtual void NetworkLeaveGame() { }

	protected virtual EftGamePlayerOwner PlayerOwnerFactory() { }

	protected virtual void SetMatchmakerStatus(EMatchingStage stage, Nullable progress = null) { }

	protected virtual void ShowFinalCountdownScreen(int seconds) { }

}

