namespace EFT.NextObservedPlayer;

public sealed class ObservedPlayerEquipmentViewController : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__18_0; //Field offset: 0x8
		public static Func <>9__18_1; //Field offset: 0x10
		public static Func <>9__23_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal IEnumerable <ApplyChangeModOnItemCommand>b__23_0(ContainerCollection x) { }

		internal string <ValidateHelmetLights>b__18_0(TacticalComboVisualController k) { }

		internal TacticalComboVisualController <ValidateHelmetLights>b__18_1(TacticalComboVisualController v) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public Slot slot; //Field offset: 0x10
		public ObservedPlayerEquipmentViewController <>4__this; //Field offset: 0x18
		public EquipmentSlot slotType; //Field offset: 0x20

		public <>c__DisplayClass22_0() { }

		internal void <SubscribeSlotVisualChanges>b__0() { }

		internal void <SubscribeSlotVisualChanges>g__SlotChangeHandler|1(Item item) { }

	}

	[CompilerGenerated]
	private struct <ApplyHelmetTacticalModeToggle>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ObservedPlayerEquipmentViewController <>4__this; //Field offset: 0x20
		public TacticalModeToggleCommandMessage command; //Field offset: 0x28
		private TacticalComboVisualController <lightController>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static readonly List VISUAL_ITEMS_WITH_MODS_SLOT_NAMES; //Field offset: 0x0
	private static readonly List VISUAL_ON_BACK_SLOT_NAMES; //Field offset: 0x8
	[CompilerGenerated]
	private BindableState <ItemInHands>k__BackingField; //Field offset: 0x10
	private PlayerBody _playerBody; //Field offset: 0x18
	private PlayerBones _playerBones; //Field offset: 0x20
	private ObservedPlayerInventoryController _inventoryController; //Field offset: 0x28
	private ObservedPlayerHandsController _handsController; //Field offset: 0x30
	private ObservedPlayerView _player; //Field offset: 0x38
	private bool _isAlive; //Field offset: 0x40
	private readonly CompositeDisposable _disposable; //Field offset: 0x48
	private Dictionary _helmetLights; //Field offset: 0x50
	private readonly Dictionary _cachedLightStates; //Field offset: 0x58

	public InventoryEquipment Equipment
	{
		 get { } //Length: 39
	}

	public private BindableState ItemInHands
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private static ObservedPlayerEquipmentViewController() { }

	public ObservedPlayerEquipmentViewController() { }

	[CompilerGenerated]
	private void <Initialize>b__17_0() { }

	private void ApplyChangeEquipCommand(ChangeEquipCommandMessage changeEquipCommandMessaged) { }

	private void ApplyChangeModOnItemCommand(ChangeModOnItemCommandMessage command) { }

	public void ApplyDeath() { }

	[AsyncStateMachine(typeof(<ApplyHelmetTacticalModeToggle>d__20))]
	private Task ApplyHelmetTacticalModeToggle(TacticalModeToggleCommandMessage command) { }

	private void ApplyToggleHeadGearCommand(HeadGearToggleCommandMessage headGearToggleCommand) { }

	public override void Dispose() { }

	private void EnableRenderOnSlotDispose(SlotView slotView) { }

	public void Execute(ICommandMessage command) { }

	public InventoryEquipment get_Equipment() { }

	[CompilerGenerated]
	public BindableState get_ItemInHands() { }

	private void InitHeadwearModVisuals(GameObject modObject, SlotView itemSlotView) { }

	public void Initialize(PlayerBody playerBody, ObservedPlayerHandsController handsController, ObservedPlayerInventoryController inventoryController, ObservedPlayerSpawnMessage spawnMessage, ObservedPlayerView player) { }

	private void OnWeaponChanged(ValueTuple prev, ValueTuple next) { }

	private void RefreshHelmetDress(Item helmetItem, SlotView itemSlotView) { }

	[CompilerGenerated]
	private void set_ItemInHands(BindableState value) { }

	private void SubscribeSlotVisualChanges(EquipmentSlot slotType, Slot slot) { }

	private void SyncSlotView(EquipmentSlot slotType, Slot slot) { }

	private void ValidateHelmetLights(GameObject parentModel) { }

}

