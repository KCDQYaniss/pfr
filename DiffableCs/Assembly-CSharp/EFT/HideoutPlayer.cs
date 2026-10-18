namespace EFT;

[UsedImplicitly]
public class HideoutPlayer : LocalPlayer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__37_0; //Field offset: 0x8
		public static Func <>9__38_1; //Field offset: 0x10
		public static Func <>9__38_3; //Field offset: 0x18
		public static Func <>9__38_4; //Field offset: 0x20
		public static Func <>9__38_5; //Field offset: 0x28
		public static Action <>9__38_10; //Field offset: 0x30
		public static Func <>9__38_7; //Field offset: 0x38

		private static <>c() { }

		public <>c() { }

		internal void <Create>b__37_0() { }

		internal Action <CreateSlotObservers>b__38_1(ThermalVisionComponent tv, Action handler) { }

		internal void <CreateSlotObservers>b__38_10() { }

		internal Action <CreateSlotObservers>b__38_3(NightVisionComponent nv, Action handler) { }

		internal Action <CreateSlotObservers>b__38_4(FaceShieldComponent fs, Action handler) { }

		internal Action <CreateSlotObservers>b__38_5(FaceShieldComponent fs, Action handler) { }

		internal Action <CreateSlotObservers>b__38_7(FaceCoverMaskComponent _, Action _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass38_0
	{
		public HideoutPlayer <>4__this; //Field offset: 0x10
		public Action nvUnsub; //Field offset: 0x18
		public Action tvUnsub; //Field offset: 0x20

		public <>c__DisplayClass38_0() { }

		internal ThermalVisionComponent <CreateSlotObservers>b__0(ThermalVisionComponent originalThermalComponent) { }

		internal NightVisionComponent <CreateSlotObservers>b__2(NightVisionComponent originalNVComponent) { }

		internal void <CreateSlotObservers>b__6() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass38_1
	{
		public Action togglableSub; //Field offset: 0x10
		public Action hitSub; //Field offset: 0x18

		public <>c__DisplayClass38_1() { }

		internal void <CreateSlotObservers>b__8() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass38_2
	{
		public Action togglableSub; //Field offset: 0x10
		public Action hitSub; //Field offset: 0x18

		public <>c__DisplayClass38_2() { }

		internal void <CreateSlotObservers>b__9() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass43_0
	{
		public Slot playerSlot; //Field offset: 0x10

		public <>c__DisplayClass43_0() { }

		internal bool <UpdateHideoutPlayerInventory>b__1(Slot slot) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass44_0
	{
		public bool handsAreEmpty; //Field offset: 0x10

		public <>c__DisplayClass44_0() { }

		internal void <ReleaseShootingRangeInventory>b__0(Result setEmptyHandsResult) { }

	}

	[CompilerGenerated]
	private struct <Create>d__37 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Profile profile; //Field offset: 0x20
		public GameWorld gameWorld; //Field offset: 0x28
		public int playerId; //Field offset: 0x30
		public Vector3 position; //Field offset: 0x34
		public EUpdateQueue updateQueue; //Field offset: 0x40
		public EUpdateMode armsUpdateMode; //Field offset: 0x44
		public EUpdateMode bodyUpdateMode; //Field offset: 0x48
		public Mode characterControllerMode; //Field offset: 0x50
		public Func getSensitivity; //Field offset: 0x58
		public Func getAimingSensitivity; //Field offset: 0x60
		public string prefix; //Field offset: 0x68
		public bool aiControl; //Field offset: 0x70
		public OfflineInventoryController inventoryController; //Field offset: 0x78
		public Quaternion rotation; //Field offset: 0x80
		public string layerName; //Field offset: 0x90
		public EPointOfView pointOfView; //Field offset: 0x98
		public OfflineHealthController healthController; //Field offset: 0xA0
		public IStatisticsManager statisticsManager; //Field offset: 0xA8
		public QuestController questController; //Field offset: 0xB0
		public AchievementsController achievementsController; //Field offset: 0xB8
		public PrestigeController prestigeController; //Field offset: 0xC0
		public ClientDialogController dialogController; //Field offset: 0xC8
		private HideoutPlayer <player>5__2; //Field offset: 0xD0
		private TaskAwaiter <>u__1; //Field offset: 0xD8

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DebugOnlyUnsureUpdateHideoutPlayerInventoryFinished>d__56 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public HideoutPlayer <>4__this; //Field offset: 0x28
		private int <i>5__2; //Field offset: 0x30
		private YieldAwaiter <>u__1; //Field offset: 0x34

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <FastForwardFromPatrol>d__46 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HideoutPlayer <>4__this; //Field offset: 0x20
		private YieldAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnGameSessionEnd>d__42 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HideoutPlayer <>4__this; //Field offset: 0x20
		public ExitStatus exitStatus; //Field offset: 0x28
		public float pastTime; //Field offset: 0x2C
		public string locationId; //Field offset: 0x30
		public string exitName; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReleaseShootingRangeInventory>d__44 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HideoutPlayer <>4__this; //Field offset: 0x20
		private <>c__DisplayClass44_0 <>8__1; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateHideoutBundles>d__47 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Profile profile; //Field offset: 0x20
		public YieldDelegate yield; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateHideoutPlayerInventory>d__43 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HideoutPlayer <>4__this; //Field offset: 0x20
		private Item <backendItemInHands>5__2; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30
		private Token <>7__wrap2; //Field offset: 0x38
		private Token <>7__wrap3; //Field offset: 0x40
		private TaskAwaiter <>u__2; //Field offset: 0x48
		private Item <item>5__5; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class HideoutNightVisionTemplate : INightVisionComponentTemplate
	{

		public override Color32 Color
		{
			 get { } //Length: 13
		}

		public override float DiffuseIntensity
		{
			 get { } //Length: 4
		}

		public override float Intensity
		{
			 get { } //Length: 9
		}

		public override EMask Mask
		{
			 get { } //Length: 6
		}

		public override float MaskSize
		{
			 get { } //Length: 9
		}

		public override float NoiseIntensity
		{
			 get { } //Length: 9
		}

		public override float NoiseScale
		{
			 get { } //Length: 9
		}

		public HideoutNightVisionTemplate() { }

		public override Color32 get_Color() { }

		public override float get_DiffuseIntensity() { }

		public override float get_Intensity() { }

		public override EMask get_Mask() { }

		public override float get_MaskSize() { }

		public override float get_NoiseIntensity() { }

		public override float get_NoiseScale() { }

	}

	private sealed class HideoutSlotObserver`1 : SlotObserver
	{
		private readonly Func _togglableComponentGetter; //Field offset: 0x0

		public virtual T Component
		{
			 get { } //Length: 77
		}

		public HideoutSlotObserver`1(Slot slot, Func togglableComponentGetter, Func subscriber) { }

		public virtual T get_Component() { }

	}

	private readonly NightVisionComponent _nightVision; //Field offset: 0xCC0
	private bool _isInShootingRange; //Field offset: 0xCC8
	private PlayerInventoryController _shootingRangeInventory; //Field offset: 0xCD0
	private Action _slotObserversUnsubscriber; //Field offset: 0xCD8
	private NightVisionComponent _lastNightVision; //Field offset: 0xCE0
	[CompilerGenerated]
	private OfflineInventoryController <OriginalInventory>k__BackingField; //Field offset: 0xCE8
	[CompilerGenerated]
	private bool <IsInPatrol>k__BackingField; //Field offset: 0xCF0
	[CompilerGenerated]
	private bool <IsUpdateHideoutPlayerInventoryInProgress>k__BackingField; //Field offset: 0xCF1
	[CompilerGenerated]
	private ClientDialogController <DialogController>k__BackingField; //Field offset: 0xCF8

	public private ClientDialogController DialogController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public bool FaceCoverMaskVisibility
	{
		 set { } //Length: 368
	}

	public virtual InventoryController InventoryController
	{
		 get { } //Length: 25
	}

	public private bool IsInPatrol
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private bool IsUpdateHideoutPlayerInventoryInProgress
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public bool NightVisionActive
	{
		 get { } //Length: 134
	}

	public private OfflineInventoryController OriginalInventory
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public virtual EPointOfView PointOfView
	{
		 get { } //Length: 67
		 set { } //Length: 241
	}

	public InventoryController ShootingRangeInventory
	{
		 get { } //Length: 8
	}

	public bool VisorVisibility
	{
		 set { } //Length: 324
	}

	public HideoutPlayer() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__0(ExitStatus exitStatus, float pastTime, string locationId, string exitName) { }

	[CompilerGenerated]
	private void <UpdateHideoutPlayerInventory>b__43_0(Result result) { }

	[CompilerGenerated]
	private void <UpdateHideoutPlayerInventory>b__43_2(Result result) { }

	[AsyncStateMachine(typeof(<Create>d__37))]
	public static Task Create(GameWorld gameWorld, int playerId, Vector3 position, Quaternion rotation, string layerName, string prefix, EPointOfView pointOfView, Profile profile, bool aiControl, EUpdateQueue updateQueue, EUpdateMode armsUpdateMode, EUpdateMode bodyUpdateMode, Mode characterControllerMode, Func getSensitivity, Func getAimingSensitivity, IStatisticsManager statisticsManager, QuestController questController, AchievementsController achievementsController, PrestigeController prestigeController, ClientDialogController dialogController, OfflineHealthController healthController, OfflineInventoryController inventoryController) { }

	protected virtual void CreateSlotObservers() { }

	[AsyncStateMachine(typeof(<DebugOnlyUnsureUpdateHideoutPlayerInventoryFinished>d__56))]
	[Conditional("DEBUG")]
	[Conditional("CONSOLE")]
	private void DebugOnlyUnsureUpdateHideoutPlayerInventoryFinished() { }

	private void DisableHeadphones() { }

	public virtual void ExecuteShotSkill(Item weapon) { }

	public virtual void ExecuteSkill(Action action) { }

	[AsyncStateMachine(typeof(<FastForwardFromPatrol>d__46))]
	private Task FastForwardFromPatrol() { }

	[CompilerGenerated]
	public ClientDialogController get_DialogController() { }

	public virtual InventoryController get_InventoryController() { }

	[CompilerGenerated]
	public bool get_IsInPatrol() { }

	[CompilerGenerated]
	public bool get_IsUpdateHideoutPlayerInventoryInProgress() { }

	public bool get_NightVisionActive() { }

	[CompilerGenerated]
	public OfflineInventoryController get_OriginalInventory() { }

	public virtual EPointOfView get_PointOfView() { }

	public InventoryController get_ShootingRangeInventory() { }

	protected virtual void InitVaultingComponent(bool aiControlled) { }

	private void NightVisionHandler() { }

	[AsyncStateMachine(typeof(<OnGameSessionEnd>d__42))]
	public virtual Task OnGameSessionEnd(ExitStatus exitStatus, float pastTime, string locationId, string exitName) { }

	protected virtual void OnSkillLevelChanged(BaseSkill skill) { }

	protected virtual void OnWeaponMastered(Mastering masterSkill) { }

	[AsyncStateMachine(typeof(<ReleaseShootingRangeInventory>d__44))]
	public Task ReleaseShootingRangeInventory() { }

	[CompilerGenerated]
	private void set_DialogController(ClientDialogController value) { }

	public void set_FaceCoverMaskVisibility(bool value) { }

	[CompilerGenerated]
	private void set_IsInPatrol(bool value) { }

	[CompilerGenerated]
	private void set_IsUpdateHideoutPlayerInventoryInProgress(bool value) { }

	[CompilerGenerated]
	private void set_OriginalInventory(OfflineInventoryController value) { }

	public virtual void set_PointOfView(EPointOfView value) { }

	public void set_VisorVisibility(bool value) { }

	public void SetHeadphonesActive(bool active) { }

	public void SetPatrol(bool patrol) { }

	private void ThermalVisionHandler() { }

	public void ToggleNightVision() { }

	protected virtual void UpdateBreathStatus() { }

	[AsyncStateMachine(typeof(<UpdateHideoutBundles>d__47))]
	private static Task UpdateHideoutBundles(Profile profile, YieldDelegate yield) { }

	[AsyncStateMachine(typeof(<UpdateHideoutPlayerInventory>d__43))]
	public Task UpdateHideoutPlayerInventory() { }

	protected virtual void UpdatePhones() { }

}

