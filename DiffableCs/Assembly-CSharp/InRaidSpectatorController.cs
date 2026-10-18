//Type is in global namespace

public class InRaidSpectatorController : ISpectatorController
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass40_0
	{
		public ObservedPlayerView teammate; //Field offset: 0x10
		public InRaidSpectatorController <>4__this; //Field offset: 0x18

		public <>c__DisplayClass40_0() { }

		internal void <ProcessStartSpectateFromServer>b__1() { }

	}

	[CompilerGenerated]
	private struct <EnterSpectatingModeDelayed>d__43 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public InRaidSpectatorController <>4__this; //Field offset: 0x20
		public ObservedPlayerView teammate; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpectateTeammateDelayed>d__45 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public int delay; //Field offset: 0x20
		public InRaidSpectatorController <>4__this; //Field offset: 0x28
		public ObservedPlayerView teammate; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private SpectatingGlobalSettings _globalSettings; //Field offset: 0x10
	[CompilerGenerated]
	private bool <IsSpectating>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private SpectatorChangedDelegate OnSpectatorChange; //Field offset: 0x20
	[CompilerGenerated]
	private SpectatorHealthEffectDisplayChangedDelegate OnHealthEffectDisplayChanged; //Field offset: 0x28
	[CompilerGenerated]
	private SpectatorHealthChangedDelegate OnSpectatorHealthChange; //Field offset: 0x30
	[CompilerGenerated]
	private TeammateDeathDelegate OnTeammateDeath; //Field offset: 0x38
	[CompilerGenerated]
	private WhiteNoiseEffectStatusChangedDelegate OnWhiteNoiseEffectStatusChanged; //Field offset: 0x40
	private Action _unsubscribeOnDestroyAction; //Field offset: 0x48
	private int _myPlayerRaidID; //Field offset: 0x50
	private SpectatorScreenController _spectatorScreenController; //Field offset: 0x58
	private SpectatorCameraEffectsController _spectatorCameraEffectsController; //Field offset: 0x60
	private ObservedPlayerView _currentTeammate; //Field offset: 0x68
	private SpectatorAudioController _spectatorAudio; //Field offset: 0x70
	private CancellationTokenSource _spectatingDelayCancellation; //Field offset: 0x78
	private int _missingSpectateTargetRetries; //Field offset: 0x80

	public override event SpectatorHealthEffectDisplayChangedDelegate OnHealthEffectDisplayChanged
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public override event SpectatorChangedDelegate OnSpectatorChange
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public override event SpectatorHealthChangedDelegate OnSpectatorHealthChange
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public override event TeammateDeathDelegate OnTeammateDeath
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public override event WhiteNoiseEffectStatusChangedDelegate OnWhiteNoiseEffectStatusChanged
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public ISpectatorAudio Audio
	{
		 get { } //Length: 5
	}

	public private bool IsSpectating
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public InRaidSpectatorController() { }

	[CompilerGenerated]
	private void <ProcessStartSpectateFromServer>g__PlayerDiedHandler|40_0(IPlayer player) { }

	[CompilerGenerated]
	public override void add_OnHealthEffectDisplayChanged(SpectatorHealthEffectDisplayChangedDelegate value) { }

	[CompilerGenerated]
	public override void add_OnSpectatorChange(SpectatorChangedDelegate value) { }

	[CompilerGenerated]
	public override void add_OnSpectatorHealthChange(SpectatorHealthChangedDelegate value) { }

	[CompilerGenerated]
	public override void add_OnTeammateDeath(TeammateDeathDelegate value) { }

	[CompilerGenerated]
	public override void add_OnWhiteNoiseEffectStatusChanged(WhiteNoiseEffectStatusChangedDelegate value) { }

	public static void ApplyTarget(ObservedPlayerView target, EPointOfView pointOfView) { }

	[AsyncStateMachine(typeof(<EnterSpectatingModeDelayed>d__43))]
	private Task EnterSpectatingModeDelayed(ObservedPlayerView teammate) { }

	private void EnterSpectatorMode(ObservedPlayerView teammate) { }

	public ISpectatorAudio get_Audio() { }

	[CompilerGenerated]
	public bool get_IsSpectating() { }

	public override IReadOnlyDictionary GetHealthStatus(int raidId) { }

	public override bool GetWhiteNoiseStatus(int raidId) { }

	private void HandleMissingSpectateTarget(int missingRaidId) { }

	private void HealthEffectDisplayChangedHandler(int raidId, bool clear, EHealthEffectType effect, int count) { }

	public void InitializeClient(Player myPlayer) { }

	public override bool IsTeammateAlive(int raidId) { }

	public void OnDestroy() { }

	private void OnSpectatorBlindnessChanged() { }

	private void OnSpectatorFaceShieldCrackingChanged() { }

	private void OnWhiteNoiseEffectStatus(bool enabled) { }

	private void PrepareLocalPlayerBodyForSpectate() { }

	private void ProcessChangeSpectatorFromServer(ChangeSpectatingTeammateEventFromServer eventFromServer) { }

	private void ProcessStartSpectateFromServer(StartSpectatingForTeammateEvent eventFromServer) { }

	[CompilerGenerated]
	public override void remove_OnHealthEffectDisplayChanged(SpectatorHealthEffectDisplayChangedDelegate value) { }

	[CompilerGenerated]
	public override void remove_OnSpectatorChange(SpectatorChangedDelegate value) { }

	[CompilerGenerated]
	public override void remove_OnSpectatorHealthChange(SpectatorHealthChangedDelegate value) { }

	[CompilerGenerated]
	public override void remove_OnTeammateDeath(TeammateDeathDelegate value) { }

	[CompilerGenerated]
	public override void remove_OnWhiteNoiseEffectStatusChanged(WhiteNoiseEffectStatusChangedDelegate value) { }

	private void RequestChangeSpectatingTeammate(bool next, int skipTargetRaidId = -1) { }

	public override void ResetCameraEffects() { }

	public static void RestoreTarget(ObservedPlayerView target) { }

	[CompilerGenerated]
	private void set_IsSpectating(bool value) { }

	private void SetInfoForMyTeammates(StartSpectatingForTeammateEvent incomeEvent) { }

	private void SpectateTeammate(ObservedPlayerView teammate) { }

	[AsyncStateMachine(typeof(<SpectateTeammateDelayed>d__45))]
	private Task SpectateTeammateDelayed(ObservedPlayerView teammate, int delay) { }

	public override void StopSpectating() { }

	private void SubscribeOnTeammate(ObservedPlayerView newTeammate) { }

	private void SyncSpectatingEnable(bool value) { }

	private void SyncSpectatingTargetInfo(SyncSpectatingTargetInfoEvent incomeEvent) { }

	public override bool TryGetPlayerIcon(int raidId, out PlayerIconRequest iconRequest) { }

	private void UnsubscribeFromTeammate(ObservedPlayerView oldTeammate) { }

	private void UpdateMyPlayerBodyRenderersOnSpectateEnter() { }

}

