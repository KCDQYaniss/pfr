namespace EFT.UI;

public abstract class BattleUIScreen`2 : BaseScreen
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__31_0; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal void <SubscribeOnPlayer>b__31_0(EVoipControllerStatus status) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public IPlayerVoipController voipController; //Field offset: 0x0
		public BattleUIScreen <>4__this; //Field offset: 0x0

		public <>c__DisplayClass31_0() { }

		internal void <SubscribeOnPlayer>b__1() { }

		internal void <SubscribeOnPlayer>b__2() { }

		internal void <SubscribeOnPlayer>g__DamageHandler|6(EBodyPart _, float __, DamageInfo ___) { }

		internal void <SubscribeOnPlayer>g__MaxSpeedChangeHandler|5(float _, float __, float ___, int ____) { }

		internal void <SubscribeOnPlayer>g__PoseLevelChangeHandler|3(float _, int __) { }

		internal void <SubscribeOnPlayer>g__SpeedChangeHandler|4(float _, float __, int ___) { }

	}

	[CompilerGenerated]
	private struct <ProcessMalfunctionExamined>d__46 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public int delayInMilliseconds; //Field offset: 0x0
		public BattleUIScreen <>4__this; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	public AmmoSelector AmmoSelector; //Field offset: 0x0
	[SerializeField]
	private CharacterHealthPanel _characterHealthPanel; //Field offset: 0x0
	[SerializeField]
	private BattleStancePanel _battleStancePanel; //Field offset: 0x0
	[SerializeField]
	private GesturesQuickPanel _gesturesPanel; //Field offset: 0x0
	[SerializeField]
	private InventoryScreenQuickAccessPanel _quickAccessPanel; //Field offset: 0x0
	[SerializeField]
	private ActionPanel _actionPanel; //Field offset: 0x0
	[SerializeField]
	private AmmoCountPanel _ammoCountPanel; //Field offset: 0x0
	[SerializeField]
	private AzimuthPanel _azimuthPanel; //Field offset: 0x0
	[SerializeField]
	private AnimatedTextPanel _opticCratePanel; //Field offset: 0x0
	[SerializeField]
	private AnimatedTextPanel _tacticalInteractionPanel; //Field offset: 0x0
	[SerializeField]
	private LocationTimeUIPanel _locationTimePanel; //Field offset: 0x0
	[SerializeField]
	private TutorialHintView _tutorialHintView; //Field offset: 0x0
	private bool _sprintDisplayBattleStance; //Field offset: 0x0
	private Player _player; //Field offset: 0x0
	private TController _controller; //Field offset: 0x0

	public ActionPanel ActionPanel
	{
		 get { } //Length: 8
	}

	public GesturesQuickPanel GesturesQuickPanel
	{
		 get { } //Length: 8
	}

	private EVisibilityMode HealthVisibility
	{
		private get { } //Length: 196
	}

	public LocationTimeUIPanel LocationTimePanel
	{
		 get { } //Length: 8
	}

	public InventoryScreenQuickAccessPanel QuickAccessPanel
	{
		 get { } //Length: 8
	}

	private EVisibilityMode QuickSlotsVisibility
	{
		private get { } //Length: 196
	}

	private EVisibilityMode StaminaVisibility
	{
		private get { } //Length: 196
	}

	protected BattleUIScreen`2() { }

	[CompilerGenerated]
	internal static void <SubscribeOnPlayer>g__ShowReportedNotification|31_7() { }

	public virtual void Close() { }

	private void CloseTutorialHint(string trigger, bool force) { }

	private void CloseTutorialHint(string trigger = null) { }

	private void DecideHealthVisibility(bool initialVisibility) { }

	private void EffectRemovedHandler(IHealthEffect effect) { }

	public ActionPanel get_ActionPanel() { }

	public GesturesQuickPanel get_GesturesQuickPanel() { }

	private EVisibilityMode get_HealthVisibility() { }

	public LocationTimeUIPanel get_LocationTimePanel() { }

	public InventoryScreenQuickAccessPanel get_QuickAccessPanel() { }

	private EVisibilityMode get_QuickSlotsVisibility() { }

	private EVisibilityMode get_StaminaVisibility() { }

	public void HideAzimuth() { }

	private void HideRaidTime() { }

	private void MalfunctionExamined(Weapon weapon) { }

	private void PlayerOnStartQuickdrawPistol() { }

	[AsyncStateMachine(typeof(<ProcessMalfunctionExamined>d__46))]
	private Task ProcessMalfunctionExamined(int delayInMilliseconds) { }

	private void PullUpBattleStancePanel() { }

	private void PullUpBattleStancePanelBySprint(bool sprinting) { }

	private void PullUpHealth() { }

	private void PullUpHealthPanelIfEffectIsImportant(IHealthEffect effect) { }

	private void PullUpQuickSlots() { }

	private void RefreshBoundSlotsView(IHandsController handsController) { }

	private void SetBattleStancePanelVisibility(bool noAutoHide) { }

	protected virtual ECursorResult ShouldLockCursor() { }

	private void Show(GamePlayerOwner owner) { }

	public virtual void Show(TController controller) { }

	public void ShowAmmoCountZeroingPanel(string message, string details = null) { }

	public void ShowAmmoDetails(int ammoCount, int maxAmmoCount, int mastering, string details, bool foldingMechanimWeapon) { }

	public void ShowAzimuth(Func valueGetter) { }

	public void ShowFireMode(EFireMode fireMode) { }

	public void ShowRaidTime() { }

	private void ShowTutorialHintHandler(TutorialHintData data) { }

	private void SightChanged(SightComponent sightComponent) { }

	private void SmoothSightChanged(SightComponent sightComponent, ESmoothScopeState state) { }

	private void SubscribeOnPlayer() { }

	private void TacticalInteractionChanged(bool isPressed) { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	public void UpdatePanelsVisibility(bool visible) { }

}

