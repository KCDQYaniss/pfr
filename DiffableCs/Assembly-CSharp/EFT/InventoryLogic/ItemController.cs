namespace EFT.InventoryLogic;

public class ItemController : IItemOwner, IContainer, IItemContainer, IDatabaseIdGenerator
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__114_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <get_IsChangingWeapon>b__114_0(ItemEventArgs x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass125_0`1
	{
		public Item item; //Field offset: 0x0

		public <>c__DisplayClass125_0`1() { }

		internal bool <SelectEvents>b__0(T activeEvent) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass126_0
	{
		public Item item; //Field offset: 0x10

		public <>c__DisplayClass126_0() { }

		internal bool <SelectEvents>b__0(ItemEventArgs activeEvent) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass129_0
	{
		public InOutHandsProcessEventArgs inOutHandsProcess; //Field offset: 0x10

		public <>c__DisplayClass129_0() { }

		internal bool <CheckItemAction>b__0(Item i) { }

		internal bool <CheckItemAction>b__1(Item i) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass150_0
	{
		public TaskCompletionSource callbackTask; //Field offset: 0x10
		public Callback callback; //Field offset: 0x18

		public <>c__DisplayClass150_0() { }

		internal void <TryRunNetworkTransaction>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass181_0
	{
		public ItemController <>4__this; //Field offset: 0x10
		public AbstractOperation operation; //Field offset: 0x18
		public Callback callback; //Field offset: 0x20

		public <>c__DisplayClass181_0() { }

		internal void <Execute>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass183_0
	{
		public ItemController <>4__this; //Field offset: 0x10
		public Magazine parentMagazine; //Field offset: 0x18

		public <>c__DisplayClass183_0() { }

		internal void <RaiseAddEvent>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass189_0
	{
		public ItemController <>4__this; //Field offset: 0x10
		public Magazine magazine; //Field offset: 0x18

		public <>c__DisplayClass189_0() { }

		internal void <RaiseRemoveEvent>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass190_0
	{
		public ItemController <>4__this; //Field offset: 0x10
		public Magazine magazine; //Field offset: 0x18

		public <>c__DisplayClass190_0() { }

		internal void <RaiseEvent>b__0() { }

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass208_0
	{
		public Item item; //Field offset: 0x0
		public Item targetItem; //Field offset: 0x8
		public ItemController <>4__this; //Field offset: 0x10
		public bool simulate; //Field offset: 0x18

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass209_0
	{
		public Item item; //Field offset: 0x0
		public ItemAddress to; //Field offset: 0x8
		public ItemController <>4__this; //Field offset: 0x10
		public bool simulate; //Field offset: 0x18

	}

	[CompilerGenerated]
	private sealed class <CacheHandlers>d__203`1 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private THandler <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		public ItemController <>4__this; //Field offset: 0x0
		private int <viewIndex>5__2; //Field offset: 0x0
		private int <i>5__3; //Field offset: 0x0

		private override THandler System.Collections.Generic.IEnumerator<THandler>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <CacheHandlers>d__203`1(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<THandler>.GetEnumerator() { }

		[DebuggerHidden]
		private override THandler System.Collections.Generic.IEnumerator<THandler>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <get_Items>d__116 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Item <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public ItemController <>4__this; //Field offset: 0x28

		private override Item System.Collections.Generic.IEnumerator<EFT.InventoryLogic.Item>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <get_Items>d__116(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.InventoryLogic.Item>.GetEnumerator() { }

		[DebuggerHidden]
		private override Item System.Collections.Generic.IEnumerator<EFT.InventoryLogic.Item>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private struct <LoadCylinderMagazine>d__138 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public bool ignoreRestrictions; //Field offset: 0x20
		public Magazine magazine; //Field offset: 0x28
		public ItemController <>4__this; //Field offset: 0x30
		public Ammo ammo; //Field offset: 0x38
		public int loadCount; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadMultiBarrelWeapon>d__139 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public int ammoCount; //Field offset: 0x20
		public Weapon weapon; //Field offset: 0x28
		public ItemController <>4__this; //Field offset: 0x30
		public Ammo ammo; //Field offset: 0x38
		public bool playSound; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadWeaponWithAmmo>d__140 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Weapon weapon; //Field offset: 0x20
		public ItemController <>4__this; //Field offset: 0x28
		public Ammo ammo; //Field offset: 0x30
		public int ammoCount; //Field offset: 0x38
		private IResult <chamberLoadResult>5__2; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RunOperation>d__201 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ExamineOperation examineOperation; //Field offset: 0x20
		public Callback callback; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class InventoryLogger
	{
		private sealed class InternalInventoryLogger : AbstractLogger
		{
			private readonly string _controllerDescription; //Field offset: 0x48

			public InternalInventoryLogger(string controllerDescription) { }

			public virtual void Log(LogLevel logLevel, string format, object[] args) { }

			protected virtual void LogFormat(LogType logType, string format, object[] args) { }

		}

		private readonly InternalInventoryLogger _logger; //Field offset: 0x10

		public InventoryLogger(ItemController itemController) { }

		[Conditional("DEBUG")]
		[Conditional("CONSOLE")]
		[Conditional("SERVER")]
		public void LogDebug(string format, object[] args) { }

		public void LogError(string format, object[] args) { }

		[Conditional("DEBUG")]
		[Conditional("CONSOLE")]
		[Conditional("SERVER")]
		public void LogInfo(string format, object[] args) { }

		[Conditional("SERVER")]
		[Conditional("DEBUG")]
		[Conditional("CONSOLE")]
		public void LogTrace(string format, object[] args) { }

		public void LogWarn(string format, object[] args) { }

	}

	private sealed class ProtectedOwnerItself : OwnerItself
	{

		public ProtectedOwnerItself(IItemOwner owner) { }

	}

	public const int CANT_EXECUTE_ERROR_CODE = 1; //Field offset: 0x0
	public const string LOAD_AMMO_IN_ITEM_ERROR = "InventoryError/You can't load ammo into this item"; //Field offset: 0x0
	public readonly InventoryLogger Logger; //Field offset: 0x10
	[CompilerGenerated]
	private Action AddItemEvent; //Field offset: 0x18
	[CompilerGenerated]
	private readonly ISearchController <SearchController>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private Action RemoveItemEvent; //Field offset: 0x28
	[CompilerGenerated]
	private Action ExamineEvent; //Field offset: 0x30
	[CompilerGenerated]
	private Action PlayerExamineEvent; //Field offset: 0x38
	[CompilerGenerated]
	private Action OnChamberCheck; //Field offset: 0x40
	[CompilerGenerated]
	private Action CreateMapMarkerEvent; //Field offset: 0x48
	[CompilerGenerated]
	private Action EditMapMarkerEvent; //Field offset: 0x50
	[CompilerGenerated]
	private Action DeleteMapMarkerEvent; //Field offset: 0x58
	[CompilerGenerated]
	private Action RefreshItemEvent; //Field offset: 0x60
	[CompilerGenerated]
	private Action ActiveEventAdded; //Field offset: 0x68
	[CompilerGenerated]
	private Action ActiveEventsChanged; //Field offset: 0x70
	[CompilerGenerated]
	private Action OnLockedStatusChange; //Field offset: 0x78
	[CompilerGenerated]
	private Action OnTraderServicePurchased; //Field offset: 0x80
	protected readonly HashSet Views; //Field offset: 0x88
	private readonly List _cachedViews; //Field offset: 0x90
	protected ushort _nextOperationId; //Field offset: 0x98
	protected MongoID IdSource; //Field offset: 0xA0
	private bool _locked; //Field offset: 0xB8
	[CompilerGenerated]
	private readonly string <ID>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	private readonly ItemFilter[] <Filters>k__BackingField; //Field offset: 0xC8
	[CompilerGenerated]
	private readonly Item <RootItem>k__BackingField; //Field offset: 0xD0
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; //Field offset: 0xD8
	[CompilerGenerated]
	private readonly bool <CanBeLocalized>k__BackingField; //Field offset: 0xE0
	[CompilerGenerated]
	private readonly EOwnerType <OwnerType>k__BackingField; //Field offset: 0xE4
	[CompilerGenerated]
	private readonly List <ActiveEvents>k__BackingField; //Field offset: 0xE8
	private readonly List _allocatedItemsList; //Field offset: 0xF0

	public event Action ActiveEventAdded
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action ActiveEventsChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action AddItemEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action CreateMapMarkerEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action DeleteMapMarkerEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action EditMapMarkerEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action ExamineEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnChamberCheck
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnLockedStatusChange
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnTraderServicePurchased
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override event Action PlayerExamineEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action RefreshItemEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action RemoveItemEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	private List ActiveEvents
	{
		[CompilerGenerated]
		private get { } //Length: 8
	}

	private bool CanBeLocalized
	{
		[CompilerGenerated]
		private get { } //Length: 8
	}

	public override string ContainerName
	{
		 get { } //Length: 147
	}

	public MongoID CurrentId
	{
		 get { } //Length: 27
	}

	private override MongoID EFT.InventoryLogic.IDatabaseIdGenerator.NextId
	{
		private get { } //Length: 58
	}

	public override ItemFilter[] Filters
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public bool HasActiveEvents
	{
		 get { } //Length: 375
	}

	public override string ID
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public override bool InboundTransfer
	{
		 get { } //Length: 3
	}

	public bool IsChangingWeapon
	{
		 get { } //Length: 355
	}

	public override IEnumerable Items
	{
		[IteratorStateMachine(typeof(<get_Items>d__116))]
		 get { } //Length: 175
	}

	public override bool Locked
	{
		 get { } //Length: 8
		 set { } //Length: 14
	}

	[CanBeNull]
	public Grid[] MainStorage
	{
		 get { } //Length: 42
	}

	public override EParentMergeType MergeContainerWithChildren
	{
		 get { } //Length: 3
	}

	public string Name
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	protected override MongoID NextId
	{
		 get { } //Length: 290
	}

	public ushort NextOperationId
	{
		 get { } //Length: 8
	}

	public override EOwnerType OwnerType
	{
		[CompilerGenerated]
		 get { } //Length: 7
	}

	public override Item ParentItem
	{
		 get { } //Length: 8
	}

	[CanBeNull]
	public override CompoundItem Root
	{
		 get { } //Length: 122
	}

	public override Item RootItem
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public override ISearchController SearchController
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ItemController(Item rootItem, string profileId, string name, bool canBeLocalized = true, EOwnerType type = 0) { }

	[CompilerGenerated]
	private OperationResult <ExecutePossibleAction>g__Apply|208_1(IApplicable applicable, ref Error error, ref <>c__DisplayClass208_0 unnamed_param_2) { }

	[CompilerGenerated]
	private OperationResult <ExecutePossibleAction>g__Merge|208_0(ref Error error, ref <>c__DisplayClass208_0 unnamed_param_1) { }

	[CompilerGenerated]
	private OperationResult <ExecutePossibleAction>g__Move|209_1(ref Error error, ref <>c__DisplayClass209_0 unnamed_param_1) { }

	[CompilerGenerated]
	private OperationResult <ExecutePossibleAction>g__Split|209_0(ref Error error, ref <>c__DisplayClass209_0 unnamed_param_1) { }

	[CompilerGenerated]
	private OperationResult <ExecutePossibleAction>g__Transfer|208_2(ref Error error, ref <>c__DisplayClass208_0 unnamed_param_1) { }

	[CompilerGenerated]
	public void add_ActiveEventAdded(Action value) { }

	[CompilerGenerated]
	public override void add_ActiveEventsChanged(Action value) { }

	[CompilerGenerated]
	public override void add_AddItemEvent(Action value) { }

	[CompilerGenerated]
	public override void add_CreateMapMarkerEvent(Action value) { }

	[CompilerGenerated]
	public override void add_DeleteMapMarkerEvent(Action value) { }

	[CompilerGenerated]
	public override void add_EditMapMarkerEvent(Action value) { }

	[CompilerGenerated]
	public void add_ExamineEvent(Action value) { }

	[CompilerGenerated]
	public void add_OnChamberCheck(Action value) { }

	[CompilerGenerated]
	public void add_OnLockedStatusChange(Action value) { }

	[CompilerGenerated]
	public void add_OnTraderServicePurchased(Action value) { }

	[CompilerGenerated]
	public override void add_PlayerExamineEvent(Action value) { }

	[CompilerGenerated]
	public override void add_RefreshItemEvent(Action value) { }

	[CompilerGenerated]
	public override void add_RemoveItemEvent(Action value) { }

	private void AddActiveEvent(ItemEventArgs activeEvent) { }

	public void AddAndRaiseEvents(Item item, ItemAddress to) { }

	[IteratorStateMachine(typeof(<CacheHandlers>d__203`1))]
	private IEnumerable CacheHandlers() { }

	private void CallMagazineChanged(Magazine magazine) { }

	public void CallPlayerExamineEvent(ExamineItemEventArgs args) { }

	public bool CanExecute(IOperationResult operationResult) { }

	internal override bool CanExecute(AbstractOperation operation) { }

	public bool CanMoveCompoundItem(Item item) { }

	public bool CanMoveDogtag(Item item) { }

	public bool CanThrow(Item item) { }

	public override void CheckChamber(Weapon weapon, bool status) { }

	public override bool CheckCompatibility(Item item) { }

	public override bool CheckedChamber(Weapon weapon) { }

	private bool CheckForOnlySpecialSlotsItem(CompoundItem compoundItem, ItemAddress location) { }

	public override Option CheckItemAction(Item item, ItemAddress location) { }

	private static bool CheckLocation(Item item, ItemAddress location, Item eventItem, ItemAddress eventLocation) { }

	public override void CheckMagazineAmmoDepend(Magazine magazine, Action callback, bool useOperation, bool allowUncheck = false) { }

	public override bool CheckOverLimit(IEnumerable items, ItemAddress to, bool useItemCountInEquipment, out CountLimitError error) { }

	private bool CheckRestrictions(Item item, ItemAddress location) { }

	private bool CheckSlotRestrictions(Item item, ItemAddress location) { }

	public override bool CheckTransferOwners(Item item, ItemAddress targetAddress, out Error error) { }

	public override AbstractOperation ConvertOperationResultToOperation(IOperationResult operationResult) { }

	public ItemAddress CreateItemAddress() { }

	private override ItemAddress EFT.InventoryLogic.IContainer.CreateItemAddress(ItemAddressDescriptor descriptor) { }

	private override int EFT.InventoryLogic.IContainer.GetHashSum() { }

	private override MongoID EFT.InventoryLogic.IDatabaseIdGenerator.get_NextId() { }

	private override void EFT.InventoryLogic.IDatabaseIdGenerator.RollBack() { }

	public override void Examine(Item item, Callback callback = null) { }

	public override bool Examined(Item item) { }

	internal override void Execute(AbstractOperation operation, Callback callback) { }

	public override void ExecuteFaceshieldMarkOperation(FaceShieldComponent armor) { }

	public OperationResult ExecutePossibleAction(ItemContext itemContext, ItemAddress to, bool partialTransferOnly, bool simulate) { }

	public OperationResult ExecutePossibleAction(ItemContext itemContext, Item targetItem, bool partialTransferOnly, bool simulate) { }

	public override void ExecuteStationaryOperation(StationaryWeapon stationaryWeapon, Callback callback = null) { }

	protected override IContainer FindContainer(ContainerDescriptor container) { }

	public TItem FindItem(string itemId) { }

	[CompilerGenerated]
	private List get_ActiveEvents() { }

	[CompilerGenerated]
	private bool get_CanBeLocalized() { }

	public override string get_ContainerName() { }

	public MongoID get_CurrentId() { }

	[CompilerGenerated]
	public override ItemFilter[] get_Filters() { }

	public bool get_HasActiveEvents() { }

	[CompilerGenerated]
	public override string get_ID() { }

	public override bool get_InboundTransfer() { }

	public bool get_IsChangingWeapon() { }

	[IteratorStateMachine(typeof(<get_Items>d__116))]
	public override IEnumerable get_Items() { }

	public override bool get_Locked() { }

	public Grid[] get_MainStorage() { }

	public override EParentMergeType get_MergeContainerWithChildren() { }

	[CompilerGenerated]
	public string get_Name() { }

	protected override MongoID get_NextId() { }

	public ushort get_NextOperationId() { }

	[CompilerGenerated]
	public override EOwnerType get_OwnerType() { }

	public override Item get_ParentItem() { }

	public override CompoundItem get_Root() { }

	[CompilerGenerated]
	public override Item get_RootItem() { }

	[CompilerGenerated]
	public override ISearchController get_SearchController() { }

	protected ushort GetAndIncrementNextOperationId() { }

	private string GetDescription() { }

	public int GetStackMaxSizeFor(Item item) { }

	public bool HasAnyHandsAction() { }

	public override bool HasForeignEvents(Item item, ItemController anotherOwner) { }

	public bool HasItemBlockInteractionsAction(Item item) { }

	public bool HasUninterruptibleAction() { }

	protected override void InProcess(ItemController executor, Item item, ItemAddress to, bool succeed, IInventoryOperation operation, Callback callback) { }

	public override void InProcess(Item item, ItemAddress to, bool succeed, IInventoryOperation operation, Callback callback) { }

	public override bool IsLimitedAtAddress(Item item, ItemAddress address, out int limit) { }

	protected override bool IsLimitedAtAddress(string templateId, ItemAddress address, out int limit) { }

	protected override bool IsRootAddressIsStash(ItemAddress location) { }

	[AsyncStateMachine(typeof(<LoadCylinderMagazine>d__138))]
	private Task LoadCylinderMagazine(Ammo ammo, Magazine magazine, int loadCount, bool ignoreRestrictions) { }

	protected override Task LoadMagazine(Ammo ammo, Magazine magazine, int loadCount, bool ignoreRestrictions) { }

	public Task LoadMagazine(Ammo ammo, Magazine magazine, int loadCount) { }

	[AsyncStateMachine(typeof(<LoadMultiBarrelWeapon>d__139))]
	public override Task LoadMultiBarrelWeapon(Weapon weapon, Ammo ammo, int ammoCount, bool playSound = true) { }

	[AsyncStateMachine(typeof(<LoadWeaponWithAmmo>d__140))]
	public override Task LoadWeaponWithAmmo(Weapon weapon, Ammo ammo, int ammoCount) { }

	public override void OnAmmoLoadedCall(int count) { }

	public override void OnAmmoUnloadedCall(int count) { }

	public override void OnMagazineCheckCall() { }

	protected override void OutProcess(ItemController executor, Item item, ItemAddress from, ItemAddress to, IInventoryOperation operation, Callback callback) { }

	public override void OutProcess(Item item, ItemAddress from, ItemAddress to, IInventoryOperation operation, Callback callback) { }

	protected void ProcessActivity(ItemEventArgs args) { }

	public override void RaiseAddEvent(AddItemEventArgs args) { }

	public override void RaiseBindItemEvent(BindItemEventArgs args) { }

	public static void RaiseCallback(IResult result, Callback callback, string operation = null) { }

	public override void RaiseCreateMapMarkerEvent(CreateMapMarkerEventArgs args) { }

	public override void RaiseDeleteMapMarkerEvent(DeleteMapMarkerEventArgs args) { }

	public override void RaiseEditMapMarkerEvent(EditMapMarkerEventArgs args) { }

	public override void RaiseEvent(DrainItemEventArgs args) { }

	public override void RaiseEvent(RefreshItemEventArgs args) { }

	public override void RaiseExamineEvent(ExamineItemEventArgs args) { }

	public void RaiseInOutProcessEvents(InOutHandsProcessEventArgs args) { }

	public override void RaiseInventoryCheckMagazine(Magazine item, float time, bool status) { }

	public override void RaiseLoadMagazineEvent(LoadMagazineEventArgs args) { }

	public override void RaiseRemoveEvent(RemoveItemEventArgs args) { }

	public override void RaiseTraderServicePurchaseEvent(ETraderServiceType serviceType, string subServiceId) { }

	public override void RaiseUnbindItemEvent(UnbindItemEventArgs args) { }

	public override void RaiseUnloadMagazineEvent(UnloadMagazineEventArgs args) { }

	public void RaiseUnpackAmmoBoxEvent(UnpackAmmoBoxEventArgs args) { }

	public override void RegisterView(IItemRelatedView view) { }

	[CompilerGenerated]
	public void remove_ActiveEventAdded(Action value) { }

	[CompilerGenerated]
	public override void remove_ActiveEventsChanged(Action value) { }

	[CompilerGenerated]
	public override void remove_AddItemEvent(Action value) { }

	[CompilerGenerated]
	public override void remove_CreateMapMarkerEvent(Action value) { }

	[CompilerGenerated]
	public override void remove_DeleteMapMarkerEvent(Action value) { }

	[CompilerGenerated]
	public override void remove_EditMapMarkerEvent(Action value) { }

	[CompilerGenerated]
	public void remove_ExamineEvent(Action value) { }

	[CompilerGenerated]
	public void remove_OnChamberCheck(Action value) { }

	[CompilerGenerated]
	public void remove_OnLockedStatusChange(Action value) { }

	[CompilerGenerated]
	public void remove_OnTraderServicePurchased(Action value) { }

	[CompilerGenerated]
	public override void remove_PlayerExamineEvent(Action value) { }

	[CompilerGenerated]
	public override void remove_RefreshItemEvent(Action value) { }

	[CompilerGenerated]
	public override void remove_RemoveItemEvent(Action value) { }

	public void RemoveActiveEvent(ItemEventArgs activeEvent) { }

	protected override void RollBack() { }

	public void RunNetworkTransaction(IOperationResult operationResult, Callback callback = null) { }

	[AsyncStateMachine(typeof(<RunOperation>d__201))]
	public Task RunOperation(ExamineOperation examineOperation, Callback callback) { }

	private void SafeActiveEventAdded(ItemEventArgs obj) { }

	private void SafeActiveEventsChanged(ItemEventArgs obj) { }

	private void SafeAddItemEventInvoke(AddItemEventArgs obj) { }

	private void SafeCreateMapMarkerEvent(CreateMapMarkerEventArgs obj) { }

	private void SafeDeleteMapMarkerEvent(DeleteMapMarkerEventArgs obj) { }

	private void SafeEditMapMarkerEvent(EditMapMarkerEventArgs obj) { }

	private void SafeExamineEvent(ExamineItemEventArgs obj) { }

	private void SafeOnChamberCheck(Weapon obj) { }

	private void SafeOnLockedStatusChange(bool obj) { }

	private void SafePlayerExamineEvent(ExamineItemEventArgs obj) { }

	private void SafeRefreshItemEvent(RefreshItemEventArgs obj) { }

	private void SafeRemoveItemEvent(RemoveItemEventArgs obj) { }

	public override IEnumerable SelectEvents(Item item) { }

	public override IEnumerable SelectEvents(Item item = null) { }

	public override void set_Locked(bool value) { }

	public override void StopProcesses() { }

	public override void StrictCheckMagazine(Magazine magazine, bool status, int skill = 0, bool notify = false, bool useOperation = true) { }

	public override void ThrowItem(Item item, bool downDirection = false, Callback callback = null) { }

	protected override ToggleOperation ToggleItem(ToggleResult toggleResult) { }

	public override ItemAddress ToItemAddress(ItemAddressDescriptor descriptor) { }

	public override bool TryFindItem(string itemId, out Item item) { }

	public override bool TryFindItem(Func predicate, out Item result) { }

	public override bool TryFindLocationForItem(Item item, out ItemAddress location) { }

	public override Task TryRunNetworkTransaction(OperationResult operationResult, Callback callback = null) { }

	public override Option TryThrowItem(Item item, Callback callback = null, bool silent = false) { }

	public override void UnregisterView(IItemRelatedView view) { }

	public void UpdateLockedStatus() { }

	protected void UpdateOperationId(InventoryOperationDescriptor descriptor) { }

}

