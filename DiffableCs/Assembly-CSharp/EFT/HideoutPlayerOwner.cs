namespace EFT;

public sealed class HideoutPlayerOwner : EftGamePlayerOwner
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass81_0
	{
		public HideoutPlayerOwner <>4__this; //Field offset: 0x10
		public Action exitAction; //Field offset: 0x18

		public <>c__DisplayClass81_0() { }

		internal void <ShowInventoryScreen>g__InventoryScreenExitAction|0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass82_0
	{
		public HideoutPlayerOwner <>4__this; //Field offset: 0x10
		public Action exitAction; //Field offset: 0x18

		public <>c__DisplayClass82_0() { }

		internal void <ShowAreaItemsTransferScreen>g__TransferScreenExitAction|0() { }

	}

	[CompilerGenerated]
	private struct <ExitShootingRange>d__65 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HideoutPlayerOwner <>4__this; //Field offset: 0x20
		private YieldAwaiter <>u__1; //Field offset: 0x28
		private TaskAwaiter <>u__2; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetShootingRangeStatus>d__86 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HideoutPlayerOwner <>4__this; //Field offset: 0x20
		public bool status; //Field offset: 0x28
		public bool forced; //Field offset: 0x29
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const int ROTATION_CLAMP = 50; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnShootingRangeStatusChange; //Field offset: 0x160
	[CompilerGenerated]
	private Action OnSelectArea; //Field offset: 0x168
	[CompilerGenerated]
	private Action OnSpecialAreaActionSelection; //Field offset: 0x170
	[CompilerGenerated]
	private Action OnSpecialAreaActionExit; //Field offset: 0x178
	[CompilerGenerated]
	private Action OnToggleInfoIcons; //Field offset: 0x180
	private bool _flashlightBlock; //Field offset: 0x188
	private IHandsInputTranslator _dummyHandsInputTranslator; //Field offset: 0x190
	private IPlayerInputTranslator _dummyInputTranslator; //Field offset: 0x198
	private bool _firstState; //Field offset: 0x1A0
	private readonly Vector3 _unseenPlayerPosition; //Field offset: 0x1A4
	private Vector3 _backupPlayerPosition; //Field offset: 0x1B0
	private Quaternion _backupPlayerRotation; //Field offset: 0x1BC
	private Vector3 _startPlayerPosition; //Field offset: 0x1CC
	private Quaternion _startPlayerRotation; //Field offset: 0x1D8
	private RuntimeAnimatorController _backupAnimatorController; //Field offset: 0x1E8
	[CompilerGenerated]
	private bool <FirstPersonMode>k__BackingField; //Field offset: 0x1F0
	[CompilerGenerated]
	private HideoutPlayer <HideoutPlayer>k__BackingField; //Field offset: 0x1F8
	[CompilerGenerated]
	private bool <InShootingRange>k__BackingField; //Field offset: 0x200
	[CompilerGenerated]
	private bool <FlashLightState>k__BackingField; //Field offset: 0x201
	[CompilerGenerated]
	private HideoutArea <HideoutArea>k__BackingField; //Field offset: 0x208
	[CompilerGenerated]
	private bool <IsGuest>k__BackingField; //Field offset: 0x210
	[CompilerGenerated]
	private string <HideoutOwnerAccountId>k__BackingField; //Field offset: 0x218

	public event Action OnSelectArea
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnShootingRangeStatusChange
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnSpecialAreaActionExit
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnSpecialAreaActionSelection
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnToggleInfoIcons
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public bool AvailableForInteractions
	{
		 get { } //Length: 52
	}

	public private bool FirstPersonMode
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private bool FlashLightState
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public virtual IHandsInputTranslator HandsInputTranslator
	{
		 get { } //Length: 25
		 set { } //Length: 89
	}

	public private HideoutArea HideoutArea
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private string HideoutOwnerAccountId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private HideoutPlayer HideoutPlayer
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private bool InShootingRange
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private bool IsGuest
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public virtual IPlayerInputTranslator PlayerInputTranslator
	{
		 get { } //Length: 25
		 set { } //Length: 82
	}

	protected virtual bool SetItemInHandsImmediately
	{
		 get { } //Length: 3
	}

	public HideoutPlayerOwner() { }

	[CompilerGenerated]
	internal static void <PrepareWorkout>g__SetupDumbbell|91_0(Transform dumbbell, Transform parent, PropsData transformData) { }

	[CompilerGenerated]
	private void <TranslateInventoryScreenInput>b__80_0() { }

	[CompilerGenerated]
	public void add_OnSelectArea(Action value) { }

	[CompilerGenerated]
	public void add_OnShootingRangeStatusChange(Action value) { }

	[CompilerGenerated]
	public void add_OnSpecialAreaActionExit(Action value) { }

	[CompilerGenerated]
	public void add_OnSpecialAreaActionSelection(Action value) { }

	[CompilerGenerated]
	public void add_OnToggleInfoIcons(Action value) { }

	protected virtual void CreateInputTranslators() { }

	public void DecidePatrolStatus(bool force = false) { }

	public void EnterShootingRange() { }

	[AsyncStateMachine(typeof(<ExitShootingRange>d__65))]
	public Task ExitShootingRange() { }

	public void ExitSpecialAreaAction(AreaData areaData, EHideoutAreaSpecialAction qte) { }

	private bool FlashlightAvailable() { }

	public bool get_AvailableForInteractions() { }

	[CompilerGenerated]
	public bool get_FirstPersonMode() { }

	[CompilerGenerated]
	public bool get_FlashLightState() { }

	public virtual IHandsInputTranslator get_HandsInputTranslator() { }

	[CompilerGenerated]
	public HideoutArea get_HideoutArea() { }

	[CompilerGenerated]
	public string get_HideoutOwnerAccountId() { }

	[CompilerGenerated]
	public HideoutPlayer get_HideoutPlayer() { }

	[CompilerGenerated]
	public bool get_InShootingRange() { }

	[CompilerGenerated]
	public bool get_IsGuest() { }

	public virtual IPlayerInputTranslator get_PlayerInputTranslator() { }

	protected virtual bool get_SetItemInHandsImmediately() { }

	public ValueTuple GetBackupPositionAndRotation() { }

	protected virtual IHandsInputTranslator GrenadeInputTranslatorFactory(IGrenadeController grenadeController) { }

	public void HideoutAreaInteraction(HideoutArea area, bool inSight) { }

	public void HidePlayer() { }

	private void HideSkinsForGym(bool hide) { }

	protected virtual void Init() { }

	protected virtual void InitBattleUIScreen() { }

	protected virtual void InteractionsChangedHandler() { }

	protected virtual IPlayerInputTranslator PlayerInputTranslatorFactory(Player player) { }

	public void PrepareWorkout(RuntimeAnimatorController animatorController, Vector3 playerPosition, Vector3 playerRotation, Transform lDumbbell, Transform rDumbbell, PropsData leftDumbbellData, PropsData rightDumbbellData) { }

	[CompilerGenerated]
	public void remove_OnSelectArea(Action value) { }

	[CompilerGenerated]
	public void remove_OnShootingRangeStatusChange(Action value) { }

	[CompilerGenerated]
	public void remove_OnSpecialAreaActionExit(Action value) { }

	[CompilerGenerated]
	public void remove_OnSpecialAreaActionSelection(Action value) { }

	[CompilerGenerated]
	public void remove_OnToggleInfoIcons(Action value) { }

	public void ResetBackupPosition() { }

	public void SelectArea(HideoutArea area) { }

	public void SelectSpecialAreaAction(AreaData areaData, EHideoutAreaSpecialAction specialAction) { }

	[CompilerGenerated]
	private void set_FirstPersonMode(bool value) { }

	[CompilerGenerated]
	private void set_FlashLightState(bool value) { }

	public virtual void set_HandsInputTranslator(IHandsInputTranslator value) { }

	[CompilerGenerated]
	private void set_HideoutArea(HideoutArea value) { }

	[CompilerGenerated]
	private void set_HideoutOwnerAccountId(string value) { }

	[CompilerGenerated]
	private void set_HideoutPlayer(HideoutPlayer value) { }

	[CompilerGenerated]
	private void set_InShootingRange(bool value) { }

	[CompilerGenerated]
	private void set_IsGuest(bool value) { }

	public virtual void set_PlayerInputTranslator(IPlayerInputTranslator value) { }

	public void SetBackupPositionAndRotation(Vector3 position, Quaternion rotation) { }

	public void SetGuest(bool isGuest, string ownerAccountId) { }

	public void SetPointOfView(bool firstPerson) { }

	[AsyncStateMachine(typeof(<SetShootingRangeStatus>d__86))]
	private Task SetShootingRangeStatus(bool status, bool forced = false) { }

	public void ShowAreaItemsTransferScreen(EAreaType areaType, Action exitAction) { }

	protected virtual void ShowBattleUIScreen() { }

	protected virtual void ShowInventoryScreen(Action exitAction, IHealthController healthController, InventoryController controller, QuestController questController, AchievementsController achievementsController, PrestigeController prestigeController, CompoundItem lootItem, EInventoryTab tab, bool showAsGridContent = false) { }

	internal virtual void Stop() { }

	public void StopWorkout() { }

	private void ToggleCameraFlashlight() { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	protected virtual bool TranslateExitScreenInput(ECommand command) { }

	protected virtual bool TranslateInventoryScreenInput(ECommand command) { }

	private void UpdateFlashlightState() { }

}

