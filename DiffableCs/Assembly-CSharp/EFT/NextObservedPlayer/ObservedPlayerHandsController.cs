namespace EFT.NextObservedPlayer;

public sealed class ObservedPlayerHandsController : ICommandExecutable, IFirearmAnimationDataRepresenter
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__140_0; //Field offset: 0x8
		public static Func <>9__140_1; //Field offset: 0x10
		public static Func <>9__140_2; //Field offset: 0x18
		public static Func <>9__146_0; //Field offset: 0x20
		public static Action <>9__146_1; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal IEnumerable <RemoveModeScheduled>b__146_0(ContainerCollection x) { }

		internal void <RemoveModeScheduled>b__146_1() { }

		internal bool <SetMaxUniqueAnimationModId>b__140_0(Slot slot) { }

		internal Mod <SetMaxUniqueAnimationModId>b__140_1(Slot slot) { }

		internal int <SetMaxUniqueAnimationModId>b__140_2(Mod mod) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass144_0
	{
		public ObservedPlayerHandsController <>4__this; //Field offset: 0x10
		public IWeaponModAudioController audioMod; //Field offset: 0x18
		public Item currentItem; //Field offset: 0x20

		public <>c__DisplayClass144_0() { }

		internal void <SetupMod>g__OnHandsChange|0(ValueTuple oldHands, ValueTuple newHands) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass146_0
	{
		public Transform objectToDelete; //Field offset: 0x10

		public <>c__DisplayClass146_0() { }

		internal void <RemoveModeScheduled>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass89_0
	{
		public ObservedPlayerView player; //Field offset: 0x10

		public <>c__DisplayClass89_0() { }

		internal GameObject <GetCreateItemMethodByControllerType>b__0(Item item) { }

		internal GameObject <GetCreateItemMethodByControllerType>b__1(Item item) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass97_0
	{
		public Item item; //Field offset: 0x10
		public ObservedPlayerHandsController <>4__this; //Field offset: 0x18

		public <>c__DisplayClass97_0() { }

		internal void <SetAnimatorsParameters>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass97_1
	{
		public IWeaponModAudioController audioMod; //Field offset: 0x10
		public <>c__DisplayClass97_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass97_1() { }

		internal void <SetAnimatorsParameters>g__OnHandsChange|0(ValueTuple oldHands, ValueTuple newHands) { }

	}

	[CompilerGenerated]
	private struct <AsyncExecute>d__111 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ObservedPlayerHandsController <>4__this; //Field offset: 0x20
		private YieldAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CreateHandsController>d__96 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ObservedPlayerHandsController <>4__this; //Field offset: 0x20
		public EHandsControllerType controllerType; //Field offset: 0x28
		public ItemDescriptor item; //Field offset: 0x30
		public EMalfunctionState malfunctionState; //Field offset: 0x38
		public string malfunctionedAmmo; //Field offset: 0x40
		public bool armed; //Field offset: 0x48
		public int ammoInChamber; //Field offset: 0x4C
		public float drawSpeedMultiplier; //Field offset: 0x50
		public float reloadSpeed; //Field offset: 0x54
		public bool ejectTape; //Field offset: 0x58
		public bool injectTape; //Field offset: 0x59
		public float animatorSpeed; //Field offset: 0x5C
		public bool bipodActive; //Field offset: 0x60
		private TaskAwaiter <>u__1; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ExecuteCommand>d__116 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ICommandMessage command; //Field offset: 0x20
		public ObservedPlayerHandsController <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ExecuteInside>d__119 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ObservedPlayerHandsController <>4__this; //Field offset: 0x20
		public ICommandMessage command; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <QueueExecute>d__112 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ObservedPlayerHandsController <>4__this; //Field offset: 0x28
		private ICommandMessage <command>5__2; //Field offset: 0x30
		private Task <cmd>5__3; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetStationaryWeaponOnSpawn>d__91 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ObservedPlayerHandsController <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpecificExecute>d__118 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SetHandsCommandMessage command; //Field offset: 0x20
		public ObservedPlayerHandsController <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpecificExecute>d__137 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ObservedPlayerHandsController <>4__this; //Field offset: 0x20
		public TacticalModeToggleCommandMessage command; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpecificExecute>d__138 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ObservedPlayerHandsController <>4__this; //Field offset: 0x20
		public ScopeModeToggleCommandMessage command; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpecificExecute>d__139 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ChangeModOnItemCommandMessage command; //Field offset: 0x20
		public ObservedPlayerHandsController <>4__this; //Field offset: 0x28
		private Slot <weaponSlot>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private Action OnChangeInHandItem; //Field offset: 0x10
	[CompilerGenerated]
	private Action OnUnequipWeaponFromDeadBody; //Field offset: 0x18
	[CompilerGenerated]
	private Action OnWeaponOut; //Field offset: 0x20
	[CompilerGenerated]
	private Action BreakLoop; //Field offset: 0x28
	private readonly ObservedPlayerView _player; //Field offset: 0x30
	private readonly PlayerBones _playerBones; //Field offset: 0x38
	private readonly IAnimator _playerAnimator; //Field offset: 0x40
	private readonly ObservedPlayerInfoContainer _playerInfoContainer; //Field offset: 0x48
	private readonly ObserverPlayerCulling _playerCullingController; //Field offset: 0x50
	private Item _item; //Field offset: 0x58
	private GameObject _itemGameObject; //Field offset: 0x60
	private WeaponPrefab _weaponPrefab; //Field offset: 0x68
	private BaseSoundPlayer _baseSoundPlayer; //Field offset: 0x70
	private FirearmsEffects _firstWeaponEffects; //Field offset: 0x78
	private EHandsControllerType _currentHandsControllerType; //Field offset: 0x80
	private WeaponPrefab _underbarrelWeaponPrefab; //Field offset: 0x88
	private BaseSoundPlayer _underbarrelWeaponSoundPlayer; //Field offset: 0x90
	private Firearms _underbarrelFirearms; //Field offset: 0x98
	private FirearmsEffects _underbarrelWeaponFirearmsEffects; //Field offset: 0xA0
	private readonly BundleAnimationBones _bundleAnimationBones; //Field offset: 0xA8
	private bool _isInventoryOpen; //Field offset: 0xB0
	private float _lastOverlapValue; //Field offset: 0xB4
	private bool _isWeaponInHands; //Field offset: 0xB8
	private Deferred _deferredErgonomicWeight; //Field offset: 0xC0
	private Deferred _deferredErgonomic; //Field offset: 0xC8
	private Action _resetAnimationOnDestroyHands; //Field offset: 0xD0
	private bool _forceFastForwardAnimations; //Field offset: 0xD8
	private bool _mainExecuteInProcess; //Field offset: 0xD9
	private readonly CancellationTokenSource _disposeCancellationTokenSource; //Field offset: 0xE0
	private bool _inReloadOperation; //Field offset: 0xE8
	private bool _neverShotFromThisWeaponBefore; //Field offset: 0xE9
	private BaseObservedPlayerHandsController _currentHandsController; //Field offset: 0xF0
	private bool _isCurrentHandsControllerDestroyed; //Field offset: 0xF8
	private bool _canPlayInventoryAnimation; //Field offset: 0xF9
	private bool _firstInitPassed; //Field offset: 0xFA
	private readonly Dictionary _streamingAnimators; //Field offset: 0x100
	private readonly Queue _privilegedQueue; //Field offset: 0x108
	private readonly Queue _secondaryQueue; //Field offset: 0x110
	private bool _secondaryExecuteInProcess; //Field offset: 0x118

	public event Action BreakLoop
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnChangeInHandItem
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnUnequipWeaponFromDeadBody
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnWeaponOut
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public BundleAnimationBones BundleAnimationBones
	{
		 get { } //Length: 8
	}

	public override BifacialTransform CurrentFireport
	{
		 get { } //Length: 30
	}

	public EHandsControllerType CurrentHandsControllerType
	{
		 get { } //Length: 7
	}

	public WeaponPrefab CurrentWeaponPrefab
	{
		 get { } //Length: 5
	}

	private static Item EmptyHands
	{
		private get { } //Length: 323
	}

	public override float ErgonomicWeight
	{
		 get { } //Length: 45
	}

	private FirearmsAnimator FirearmsAnimator
	{
		private get { } //Length: 236
	}

	public TransformLinks HandsHierarchy
	{
		 get { } //Length: 18
	}

	public bool InReloadOperation
	{
		 get { } //Length: 8
	}

	public bool IsInventoryOpen
	{
		 get { } //Length: 8
	}

	public bool IsWeaponTriggerPressing
	{
		 get { } //Length: 265
	}

	public GameObject ItemGameObject
	{
		 get { } //Length: 5
	}

	public Item ItemInHands
	{
		 get { } //Length: 5
	}

	public Vector3 KnifeGlobalSwingDirection
	{
		 get { } //Length: 190
	}

	public override bool MouseLookControl
	{
		 get { } //Length: 3
	}

	public ObservedPlayerView PlayerView
	{
		 get { } //Length: 76
	}

	public override float TotalErgonomics
	{
		 get { } //Length: 45
	}

	public OpticSight UsableItemOpticSight
	{
		 get { } //Length: 205
	}

	public override Weapon Weapon
	{
		 get { } //Length: 119
	}

	public WeaponSoundPlayer WeaponSoundPlayer
	{
		 get { } //Length: 119
	}

	public ObservedPlayerHandsController(ObservedPlayerView player, ObservedPlayerInfoContainer playerInfoContainer, ObserverPlayerCulling playerCullingController) { }

	[CompilerGenerated]
	private bool <CreateHandsController>b__96_0() { }

	[CompilerGenerated]
	private bool <CreateHandsController>b__96_1() { }

	[CompilerGenerated]
	public void add_BreakLoop(Action value) { }

	[CompilerGenerated]
	public void add_OnChangeInHandItem(Action value) { }

	[CompilerGenerated]
	public void add_OnUnequipWeaponFromDeadBody(Action value) { }

	[CompilerGenerated]
	public void add_OnWeaponOut(Action value) { }

	public void AfterWeaponOut() { }

	public void ApplyDeath() { }

	public void ApplyMovementModel(ObservedPlayerMovementModel nextModel) { }

	private void ApplyOverlap(float overlap) { }

	[AsyncStateMachine(typeof(<AsyncExecute>d__111))]
	private Task AsyncExecute() { }

	public void BlindFire(int value) { }

	public static Ammo CreateAmmo(Nullable ammoTemplate) { }

	private void CreateFlareShot(Ammo flareItem, Vector3 shotPosition, Vector3 forward) { }

	[AsyncStateMachine(typeof(<CreateHandsController>d__96))]
	public Task CreateHandsController(EHandsControllerType controllerType, ItemDescriptor item, EMalfunctionState malfunctionState = 0, string malfunctionedAmmo = "", bool armed = true, int ammoInChamber = 0, float drawSpeedMultiplier = 1, bool bipodActive = false, float reloadSpeed = 1, bool ejectTape = false, bool injectTape = false, float animatorSpeed = 1) { }

	private GameObject CreateObjectItem(Item item, Func createItem) { }

	private void CreateRocketShot(Ammo rocketItem, Vector3 shotPosition, Vector3 forward) { }

	public void DestroyHandsController() { }

	public void DisableLightsState() { }

	public void Dispose() { }

	private void EnterMountingState() { }

	private float ErgonomicWeightFunc() { }

	public override void Execute(ICommandMessage command) { }

	private void ExecuteChangeEquipOnDeadBody(ChangeEquipCommandMessage equipCommand) { }

	[AsyncStateMachine(typeof(<ExecuteCommand>d__116))]
	private Task ExecuteCommand(ICommandMessage command) { }

	[AsyncStateMachine(typeof(<ExecuteInside>d__119))]
	private Task ExecuteInside(ICommandMessage command) { }

	public void ExecuteSpectator(ICommandMessage command) { }

	private void ExitMountingState() { }

	public void FastForward() { }

	private void FireAnimationStart() { }

	public bool FirearmInHands() { }

	private void FireShotBallistic(Vector3 shotPosition, Vector3 shotDirection, Ammo ammo) { }

	private void FireShotEffects(FirearmsEffects firearmsEffects) { }

	private void FireShotRecoil(Ammo ammo) { }

	private void FireShotSound(Vector3 shotPosition, Vector3 shotDirection, Ammo ammo, BaseSoundPlayer baseSoundPlayer) { }

	public BundleAnimationBones get_BundleAnimationBones() { }

	public override BifacialTransform get_CurrentFireport() { }

	public EHandsControllerType get_CurrentHandsControllerType() { }

	public WeaponPrefab get_CurrentWeaponPrefab() { }

	private static Item get_EmptyHands() { }

	public override float get_ErgonomicWeight() { }

	private FirearmsAnimator get_FirearmsAnimator() { }

	public TransformLinks get_HandsHierarchy() { }

	public bool get_InReloadOperation() { }

	public bool get_IsInventoryOpen() { }

	public bool get_IsWeaponTriggerPressing() { }

	public GameObject get_ItemGameObject() { }

	public Item get_ItemInHands() { }

	public Vector3 get_KnifeGlobalSwingDirection() { }

	public override bool get_MouseLookControl() { }

	public ObservedPlayerView get_PlayerView() { }

	public override float get_TotalErgonomics() { }

	public OpticSight get_UsableItemOpticSight() { }

	public override Weapon get_Weapon() { }

	public WeaponSoundPlayer get_WeaponSoundPlayer() { }

	private static Func GetCreateItemMethodByControllerType(EHandsControllerType controllerType, ObservedPlayerView player) { }

	private int GetMaxTimeForOperation(ICommandMessage command) { }

	private EWeaponAnimationType GetWeaponAnimationType() { }

	private void HackBrokenHands(ICommandMessage command) { }

	public void Initialize() { }

	private void InitStreamingAnimators() { }

	private void InitUnderbarrelSoundAndVisualShotEffects(Weapon weapon, WeaponPrefab weaponPrefab) { }

	private void InvokeShotEffects(Ammo ammo, Vector3 shotPosition, Vector3 shotDirection) { }

	private void InvokeUnderbarrelShotEffects(Ammo ammo, Vector3 shotPosition, Vector3 shotDirection) { }

	[Conditional("UNITY_EDITOR")]
	private static void LogCommandInfo(string text, LogLevel logLevel = 0) { }

	public void ManualUpdate() { }

	private void OnStateChanged(EPlayerState prevState, EPlayerState nextState) { }

	private void PlayAimingSound() { }

	[AsyncStateMachine(typeof(<QueueExecute>d__112))]
	private void QueueExecute() { }

	public override void RecalculateErgonomic() { }

	[CompilerGenerated]
	public void remove_BreakLoop(Action value) { }

	[CompilerGenerated]
	public void remove_OnChangeInHandItem(Action value) { }

	[CompilerGenerated]
	public void remove_OnUnequipWeaponFromDeadBody(Action value) { }

	[CompilerGenerated]
	public void remove_OnWeaponOut(Action value) { }

	private void RemoveMode(Slot slot) { }

	public Action RemoveModeScheduled(Slot slot) { }

	private void ResetAllAnimationModsId() { }

	public void ResetAnimatorOnDespawnHands() { }

	private void ResetBlindFire() { }

	private void SetAiming(bool isAiming, int aimIndex) { }

	private void SetAnimatorsParameters(Item item, EHandsControllerType controllerType, EMalfunctionState malfunctionState, string malfunctionedAmmo, bool armed, int ammoInChamber, float drawAnimSpeed, float reloadSpeed, bool ejectTape = false, bool injectTape = false, float animatorSpeed = 1) { }

	private void SetBodyAnimationByWeaponType() { }

	private void SetCompassState(bool isActive) { }

	public void SetCurrentWeaponMuzzleActiveState(bool isActive) { }

	public void SetFlagForInfoInReloadOperation(bool value) { }

	public void SetInteract(bool isInteract, int animationId) { }

	private void SetInventory(bool isOpen) { }

	private void SetMaxUniqueAnimationModId(Weapon weapon) { }

	private void SetModsParamsInAnimator(IEnumerable mods) { }

	public void SetMountingState(bool value) { }

	private void SetPickupState(bool pickup) { }

	[AsyncStateMachine(typeof(<SetStationaryWeaponOnSpawn>d__91))]
	public Task SetStationaryWeaponOnSpawn() { }

	public static void SetupItemInSlot(Slot slot, Item item) { }

	public void SetupMod(Slot slot, Item item, IPlayer player) { }

	[AsyncStateMachine(typeof(<SpecificExecute>d__137))]
	private Task SpecificExecute(TacticalModeToggleCommandMessage command) { }

	private Task SpecificExecute(InventoryOpenStatusCommandMessage command) { }

	[AsyncStateMachine(typeof(<SpecificExecute>d__118))]
	private Task SpecificExecute(SetHandsCommandMessage command) { }

	private void SpecificExecute(ShotFirearmCommandMessage command) { }

	private void SpecificExecute(UnderbarrelShotCommandMessage command) { }

	private void SpecificExecute(RocketLauncherShotCommandMessage command) { }

	private void SpecificExecute(FlareShotFirearmCommandMessage command) { }

	private Task SpecificExecute(AimingCommandMessage command) { }

	private Task SpecificExecute(InteractCommandMessage commandMessage) { }

	private Task SpecificExecute(MedEffectStatusCommandMessage command) { }

	private Task SpecificExecute(PickupCommandMessage commandMessage) { }

	private Task SpecificExecute(ToggleBipodCommandMessage commandMessage) { }

	[AsyncStateMachine(typeof(<SpecificExecute>d__138))]
	private Task SpecificExecute(ScopeModeToggleCommandMessage command) { }

	[AsyncStateMachine(typeof(<SpecificExecute>d__139))]
	private Task SpecificExecute(ChangeModOnItemCommandMessage command) { }

	private Task SpecificExecute(CompassStateCommandMessage commandMessage) { }

	private void StationaryWeaponFire() { }

	private float TotalErgonomicsFunc() { }

	private void UnderbarrelFireAnimationStart() { }

	public void UpdateHandsForSpectating() { }

	private void UpdateIsWeaponWithSilencer() { }

	public void WeaponHitReaction(Vector3 direction, float strength = 1, float hands = 1, float camera = 1) { }

	private static int WeaponSizeModifier(Item item) { }

}

