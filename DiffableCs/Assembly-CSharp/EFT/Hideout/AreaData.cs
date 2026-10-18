namespace EFT.Hideout;

public sealed class AreaData : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__125_2; //Field offset: 0x8
		public static Func <>9__125_3; //Field offset: 0x10
		public static Func <>9__128_0; //Field offset: 0x18
		public static Func <>9__139_0; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal bool <CanBuild>b__128_0(Requirement requirement) { }

		internal bool <CheckVisibility>b__139_0(Requirement requirement) { }

		internal bool <SetProductionSchemes>b__125_2(BaseHideoutScheme scheme) { }

		internal bool <SetProductionSchemes>b__125_3(BaseHideoutScheme scheme) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass125_0
	{
		public EAreaType areaType; //Field offset: 0x10
		public Profile profile; //Field offset: 0x18
		public QuestController questController; //Field offset: 0x20

		public <>c__DisplayClass125_0() { }

		internal bool <SetProductionSchemes>g__AreAllRequirementsFulfilled|0(BaseHideoutScheme scheme, int stageLevel) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass125_1
	{
		public int level; //Field offset: 0x10
		public <>c__DisplayClass125_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass125_1() { }

		internal bool <SetProductionSchemes>b__1(BaseHideoutScheme scheme) { }

	}

	[CompilerGenerated]
	private struct <InitConstructing>d__116 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public AreaData <>4__this; //Field offset: 0x20
		public int timestamp; //Field offset: 0x28
		public bool alreadyUnderConstructing; //Field offset: 0x2C
		private Stage <currentStage>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartAutoUpgrade>d__120 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public AreaData <>4__this; //Field offset: 0x20
		private Stage <currentStage>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpgradeAction>d__117 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public AreaData <>4__this; //Field offset: 0x20
		private CancellationToken <cancellationToken>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private float <waitingTime>5__3; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WaitUpgradeTime>d__119 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public float waitingTime; //Field offset: 0x20
		public AreaData <>4__this; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string CONSTRUCT_LABEL = "CONSTRUCT"; //Field offset: 0x0
	private const string CONSTRUCTING_LABEL = "CONSTRUCTING"; //Field offset: 0x0
	private const string INSTALL_LABEL = "INSTALL"; //Field offset: 0x0
	private const string UPGRADE_LABEL = "UPGRADE"; //Field offset: 0x0
	private const string UPGRADING_LABEL = "UPGRADING"; //Field offset: 0x0
	private const int AREA_CAMERA_PRIORITY = 100; //Field offset: 0x0
	[CompilerGenerated]
	private readonly AreaTemplate <Template>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Transform <AreaIconPoint>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private CinemachineVirtualCamera <AreaCamera>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private CinemachineVirtualCamera <SpecialActionCamera>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private bool <Selected>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private bool <IsActive>k__BackingField; //Field offset: 0x31
	[CompilerGenerated]
	private bool <HasActiveProduction>k__BackingField; //Field offset: 0x32
	[CompilerGenerated]
	private AreaData <ParentAreaData>k__BackingField; //Field offset: 0x38
	public readonly BindableEvent LevelUpdated; //Field offset: 0x40
	public readonly BindableEvent StatusUpdated; //Field offset: 0x48
	public readonly BindableEvent AreaUpgraded; //Field offset: 0x50
	public readonly BindableEvent RecalculateAreas; //Field offset: 0x58
	public readonly BindableEvent LightStatusChanged; //Field offset: 0x60
	public readonly BindableEvent ProductionStateChanged; //Field offset: 0x68
	public readonly BindableEvent ImprovementsUpdated; //Field offset: 0x70
	public readonly BindableEvent OnHover; //Field offset: 0x78
	public readonly BindableEvent OnSelected; //Field offset: 0x80
	public readonly BindableEvent IconStatusUpdated; //Field offset: 0x88
	public readonly BindableEvent VisibilityChanged; //Field offset: 0x90
	private HideoutArea _hideoutArea; //Field offset: 0x98
	private int _actionGoingStatus; //Field offset: 0xA0
	private bool _isVisible; //Field offset: 0xA4
	private int _currentLevel; //Field offset: 0xA8
	private readonly List _childAreasData; //Field offset: 0xB0
	private bool _completeActionSentToBackend; //Field offset: 0xB8
	private readonly CompositeDisposable _compositeDisposable; //Field offset: 0xC0
	private EAreaStatus _status; //Field offset: 0xC8
	private ELightStatus _lightStatus; //Field offset: 0xCC
	[CompilerGenerated]
	private bool <IsGuestData>k__BackingField; //Field offset: 0xD0

	public ValueTuple ActionButtonStatus
	{
		 get { } //Length: 424
	}

	public private CinemachineVirtualCamera AreaCamera
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private Transform AreaIconPoint
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public IReadOnlyList ChildAreasData
	{
		 get { } //Length: 8
	}

	public private int CurrentLevel
	{
		 get { } //Length: 7
		private set { } //Length: 7
	}

	public Stage CurrentStage
	{
		 get { } //Length: 14
	}

	public HideoutDialogEntryPoint[] DialogEntryPoints
	{
		 get { } //Length: 18
	}

	public bool DisplayInterface
	{
		 get { } //Length: 40
	}

	public bool DisplayLevel
	{
		 get { } //Length: 27
	}

	public bool DisplayNotification
	{
		 get { } //Length: 47
	}

	public bool DisplayOutOfFuelIcon
	{
		 get { } //Length: 208
	}

	public bool Enabled
	{
		 get { } //Length: 27
	}

	public private bool HasActiveProduction
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public Color HighlightColor
	{
		 get { } //Length: 36
	}

	public Transform HighlightTransform
	{
		 get { } //Length: 41
	}

	public bool IsActive
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public private bool IsGuestData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public bool IsInstalled
	{
		 get { } //Length: 50
	}

	public bool IsVisible
	{
		 get { } //Length: 8
	}

	public ELightStatus LightStatus
	{
		 get { } //Length: 7
		 set { } //Length: 112
	}

	public Stage NextStage
	{
		 get { } //Length: 16
	}

	public private AreaData ParentAreaData
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public string ParentAreaId
	{
		 get { } //Length: 27
	}

	public bool ReadyForAction
	{
		 get { } //Length: 41
	}

	public RelatedRequirements Requirements
	{
		 get { } //Length: 30
	}

	public private bool Selected
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private CinemachineVirtualCamera SpecialActionCamera
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public HideoutAreaStashController StashController
	{
		 get { } //Length: 21
	}

	public private EAreaStatus Status
	{
		 get { } //Length: 7
		private set { } //Length: 65
	}

	public AreaTemplate Template
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	private TimeSpan TimeLeft
	{
		private get { } //Length: 440
	}

	public string TimeLeftFormatted
	{
		 get { } //Length: 378
	}

	public AreaData(AreaTemplate template) { }

	public void AddChildArea(AreaData areaData) { }

	public void AttachVideoCard(int count) { }

	private bool CanBuild(Stage stage) { }

	private bool CanBuild(int level) { }

	public void CheckVisibility() { }

	public void DecideStatus(int levelToSet) { }

	public void DetachVideoCard() { }

	public override void Dispose() { }

	private void FocusMainCamera(bool focus) { }

	public void FocusSpecialActionCamera(bool focus) { }

	public ValueTuple get_ActionButtonStatus() { }

	[CompilerGenerated]
	public CinemachineVirtualCamera get_AreaCamera() { }

	[CompilerGenerated]
	public Transform get_AreaIconPoint() { }

	public IReadOnlyList get_ChildAreasData() { }

	public int get_CurrentLevel() { }

	public Stage get_CurrentStage() { }

	public HideoutDialogEntryPoint[] get_DialogEntryPoints() { }

	public bool get_DisplayInterface() { }

	public bool get_DisplayLevel() { }

	public bool get_DisplayNotification() { }

	public bool get_DisplayOutOfFuelIcon() { }

	public bool get_Enabled() { }

	[CompilerGenerated]
	public bool get_HasActiveProduction() { }

	public Color get_HighlightColor() { }

	public Transform get_HighlightTransform() { }

	[CompilerGenerated]
	public bool get_IsActive() { }

	[CompilerGenerated]
	public bool get_IsGuestData() { }

	public bool get_IsInstalled() { }

	public bool get_IsVisible() { }

	public ELightStatus get_LightStatus() { }

	public Stage get_NextStage() { }

	[CompilerGenerated]
	public AreaData get_ParentAreaData() { }

	public string get_ParentAreaId() { }

	public bool get_ReadyForAction() { }

	public RelatedRequirements get_Requirements() { }

	[CompilerGenerated]
	public bool get_Selected() { }

	[CompilerGenerated]
	public CinemachineVirtualCamera get_SpecialActionCamera() { }

	public HideoutAreaStashController get_StashController() { }

	public EAreaStatus get_Status() { }

	[CompilerGenerated]
	public AreaTemplate get_Template() { }

	private TimeSpan get_TimeLeft() { }

	public string get_TimeLeftFormatted() { }

	public void GetProducedItemsHandler(IEnumerable items) { }

	public void Hover(bool value) { }

	public void InitArea(HideoutArea area) { }

	[AsyncStateMachine(typeof(<InitConstructing>d__116))]
	private Task InitConstructing(int timestamp, bool alreadyUnderConstructing) { }

	public void InitProfileData(AreaInfo areaInfo, InventoryController inventoryController, IEftSession session, bool silent = false) { }

	public void ReleaseSubscriptions() { }

	[CompilerGenerated]
	private void set_AreaCamera(CinemachineVirtualCamera value) { }

	[CompilerGenerated]
	private void set_AreaIconPoint(Transform value) { }

	private void set_CurrentLevel(int value) { }

	[CompilerGenerated]
	private void set_HasActiveProduction(bool value) { }

	[CompilerGenerated]
	public void set_IsActive(bool value) { }

	[CompilerGenerated]
	private void set_IsGuestData(bool value) { }

	public void set_LightStatus(ELightStatus value) { }

	[CompilerGenerated]
	private void set_ParentAreaData(AreaData value) { }

	[CompilerGenerated]
	private void set_Selected(bool value) { }

	[CompilerGenerated]
	private void set_SpecialActionCamera(CinemachineVirtualCamera value) { }

	private void set_Status(EAreaStatus value) { }

	public void SetAreaStash(CompoundItem stash, Dictionary mannequinPoses) { }

	private void SetCurrentLevel(int level, bool silent = false) { }

	public void SetCurrentLevelDumb(int level, bool silent = false) { }

	public void SetDataOwner(bool isGuest) { }

	public void SetImprovements() { }

	public void SetProducedItemsHandler(ItemsProducerBase producer, Item[] items, ProducingItemController _) { }

	public void SetProductionSchemes(IEnumerable productionSchemes, Profile profile, QuestController questController) { }

	public void SetProductionState(bool active) { }

	public void SetSelectedStatus(bool isSelected) { }

	public Stage StageAt(int level) { }

	[AsyncStateMachine(typeof(<StartAutoUpgrade>d__120))]
	private Task StartAutoUpgrade() { }

	public virtual string ToString() { }

	public void TryContinueWaitUpgrade() { }

	private void Upgrade(bool silent = false) { }

	[AsyncStateMachine(typeof(<UpgradeAction>d__117))]
	public Task UpgradeAction() { }

	private void UpgradeChildAreas(bool silent) { }

	[AsyncStateMachine(typeof(<WaitUpgradeTime>d__119))]
	private Task WaitUpgradeTime(float waitingTime, CancellationToken cancellationToken) { }

}

