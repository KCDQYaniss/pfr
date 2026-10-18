namespace EFT.InventoryLogic;

public class InventoryController : PersonItemController, IMalfunctionController, IContainer, IItemContainer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__53_0; //Field offset: 0x8
		public static Func <>9__53_1; //Field offset: 0x10
		public static Func <>9__89_0; //Field offset: 0x18
		public static Func <>9__89_3; //Field offset: 0x20
		public static Func <>9__89_1; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal string <.ctor>b__53_0(RestrictionInRaid restriction) { }

		internal int <.ctor>b__53_1(RestrictionInRaid restriction) { }

		internal MongoID <CheckOverLimit>b__89_0(Item selecting) { }

		internal int <CheckOverLimit>b__89_1(Item x) { }

		internal int <CheckOverLimit>b__89_3(Item x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass67_0
	{
		public InventoryController <>4__this; //Field offset: 0x10
		public Slot parentSlot; //Field offset: 0x18

		public <>c__DisplayClass67_0() { }

		internal Slot <IsAtBindablePlace>b__0(EquipmentSlot slotType) { }

		internal bool <IsAtBindablePlace>b__1(Slot slot) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass78_0
	{
		public Item item; //Field offset: 0x10

		public <>c__DisplayClass78_0() { }

		internal bool <UnbindItemDirect>b__0(KeyValuePair x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass81_0
	{
		public InventoryController <>4__this; //Field offset: 0x10
		public ExamineOperation operation; //Field offset: 0x18
		public Callback callback; //Field offset: 0x20
		public Callback <>9__1; //Field offset: 0x28

		public <>c__DisplayClass81_0() { }

		internal void <Examine>b__0(IResult examineResult) { }

		internal void <Examine>b__1(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass89_0
	{
		public Item first; //Field offset: 0x10

		public <>c__DisplayClass89_0() { }

		internal bool <CheckOverLimit>b__2(Item x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass92_0
	{
		public Magazine magazine; //Field offset: 0x10
		public bool status; //Field offset: 0x18

		public <>c__DisplayClass92_0() { }

		internal void <SetMagazineCheckedStatus>b__0(IResult arg) { }

	}

	[CompilerGenerated]
	private sealed class <get_EquipmentItems>d__51 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private CompoundItem <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public InventoryController <>4__this; //Field offset: 0x28
		private Slot[] <>7__wrap1; //Field offset: 0x30
		private int <>7__wrap2; //Field offset: 0x38

		private override CompoundItem System.Collections.Generic.IEnumerator<EFT.InventoryLogic.CompoundItem>.Current
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
		public <get_EquipmentItems>d__51(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.InventoryLogic.CompoundItem>.GetEnumerator() { }

		[DebuggerHidden]
		private override CompoundItem System.Collections.Generic.IEnumerator<EFT.InventoryLogic.CompoundItem>.get_Current() { }

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
	private struct <TryPurchaseTraderServiceInternal>d__70 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ETraderServiceType serviceType; //Field offset: 0x20
		public string subServiceId; //Field offset: 0x28
		public QuestController questController; //Field offset: 0x30
		public InventoryController <>4__this; //Field offset: 0x38
		public bool simulate; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UnloadAmmoInstantly>d__72`1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public TContainer ammoContainer; //Field offset: 0x0
		public InventoryController <>4__this; //Field offset: 0x0
		public bool equipmentBlocked; //Field offset: 0x0
		private string <sound>5__2; //Field offset: 0x0
		private bool <hadSuccess>5__3; //Field offset: 0x0
		private OperationResult <result>5__4; //Field offset: 0x0
		private IEnumerable <targets>5__5; //Field offset: 0x0
		private bool <isAmmoBox>5__6; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UnloadSlots>d__75 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IReadOnlyList slots; //Field offset: 0x20
		public InventoryController <>4__this; //Field offset: 0x28
		public bool equipmentBlocked; //Field offset: 0x30
		private IEnumerable <targets>5__2; //Field offset: 0x38
		private string <sound>5__3; //Field offset: 0x40
		private int <i>5__4; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static readonly EquipmentSlot[] _hiddenFromSelf; //Field offset: 0x0
	private static readonly EquipmentSlot[] _hiddenFromOthers; //Field offset: 0x8
	private static readonly EquipmentSlot[] _animatedSlots; //Field offset: 0x10
	[CompilerGenerated]
	private Inventory <Inventory>k__BackingField; //Field offset: 0x100
	[CompilerGenerated]
	private readonly IInventoryProfileInfo <Profile>k__BackingField; //Field offset: 0x108
	[CompilerGenerated]
	private readonly ContainerCollection <QuestStashItem>k__BackingField; //Field offset: 0x110
	[CompilerGenerated]
	private readonly ContainerCollection <QuestRaidItem>k__BackingField; //Field offset: 0x118
	[CompilerGenerated]
	private PlayerRecorderController <RecorderController>k__BackingField; //Field offset: 0x120
	[CompilerGenerated]
	private Action CriticalInventoryErrorHappened; //Field offset: 0x128
	[CompilerGenerated]
	private Action OnAmmoLoaded; //Field offset: 0x130
	[CompilerGenerated]
	private Action OnAmmoUnloaded; //Field offset: 0x138
	[CompilerGenerated]
	private Action OnMagazineCheck; //Field offset: 0x140
	[CompilerGenerated]
	private CompletableStatusDelegate OnCompletableItemProgressChanged; //Field offset: 0x148
	[CompilerGenerated]
	private Action OnProfileUpdate; //Field offset: 0x150
	[CompilerGenerated]
	private Action ExamineMalfunctionEvent; //Field offset: 0x158
	private readonly Dictionary _restrictionsInRaid; //Field offset: 0x160
	private readonly bool _examined; //Field offset: 0x168
	private bool _examining; //Field offset: 0x169

	public event Action CriticalInventoryErrorHappened
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public override event Action ExamineMalfunctionEvent
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnAmmoLoaded
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnAmmoUnloaded
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event CompletableStatusDelegate OnCompletableItemProgressChanged
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public event Action OnMagazineCheck
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public event Action OnProfileUpdate
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public IEnumerable EquipmentItems
	{
		[IteratorStateMachine(typeof(<get_EquipmentItems>d__51))]
		 get { } //Length: 175
	}

	public FastAccess FastAccess
	{
		 get { } //Length: 30
	}

	public private Inventory Inventory
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override Item ItemInHands
	{
		 get { } //Length: 3
	}

	protected override int MalfunctionOwnerRaidId
	{
		 get { } //Length: 3
	}

	public override IInventoryProfileInfo Profile
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	[CanBeNull]
	protected ContainerCollection QuestRaidItem
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	[CanBeNull]
	protected ContainerCollection QuestStashItem
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public PlayerRecorderController RecorderController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public virtual CompoundItem Root
	{
		 get { } //Length: 30
	}

	private static InventoryController() { }

	public InventoryController(IInventoryProfileInfo profile, bool examined) { }

	[CompilerGenerated]
	public void add_CriticalInventoryErrorHappened(Action value) { }

	[CompilerGenerated]
	public override void add_ExamineMalfunctionEvent(Action value) { }

	[CompilerGenerated]
	public void add_OnAmmoLoaded(Action value) { }

	[CompilerGenerated]
	public void add_OnAmmoUnloaded(Action value) { }

	[CompilerGenerated]
	public void add_OnCompletableItemProgressChanged(CompletableStatusDelegate value) { }

	[CompilerGenerated]
	public void add_OnMagazineCheck(Action value) { }

	[CompilerGenerated]
	public void add_OnProfileUpdate(Action value) { }

	public override void CallMalfunctionRepaired(Weapon weapon) { }

	public override void CallUnknownMalfunctionStartRepair(Weapon weapon) { }

	public virtual void CheckChamber(Weapon weapon, bool status) { }

	public virtual bool CheckedChamber(Weapon weapon) { }

	public override bool CheckedMagazine(Magazine magazine) { }

	public IResult CheckInRaidItemsRestrictions() { }

	public virtual bool CheckOverLimit(IEnumerable items, ItemAddress to, bool useItemCountInEquipment, out CountLimitError error) { }

	public override void CollectCompletableItem(CompletableItem completable) { }

	private override int EFT.InventoryLogic.IContainer.GetHashSum() { }

	private override bool EFT.InventoryLogic.IMalfunctionController.HasKnownMalfType(Weapon weapon) { }

	private override bool EFT.InventoryLogic.IMalfunctionController.HasKnownMalfunction(Weapon weapon) { }

	public virtual void Examine(Item item, Callback callback = null) { }

	public virtual bool Examined(Item item) { }

	public bool Examined(MongoID item) { }

	public override void ExamineMalfunction(Weapon weapon, bool clearRest = false) { }

	public override void ExamineMalfunctionType(Weapon weapon) { }

	protected virtual IContainer FindContainer(ContainerDescriptor container) { }

	public Option FindDestroyedItems(IEnumerable itemsData, bool skipMissingItems = false) { }

	public override Option FindItemById(MongoID itemId, bool checkDistance = true, bool checkOwnership = true) { }

	[CanBeNull]
	public override GridItemAddress FindQuestGridToPickUp(Item item) { }

	public override Task FinishQuest(ConditionalFinishResult questFinishResult) { }

	[IteratorStateMachine(typeof(<get_EquipmentItems>d__51))]
	public IEnumerable get_EquipmentItems() { }

	public FastAccess get_FastAccess() { }

	[CompilerGenerated]
	public Inventory get_Inventory() { }

	public override Item get_ItemInHands() { }

	protected override int get_MalfunctionOwnerRaidId() { }

	[CompilerGenerated]
	public override IInventoryProfileInfo get_Profile() { }

	[CompilerGenerated]
	protected ContainerCollection get_QuestRaidItem() { }

	[CompilerGenerated]
	protected ContainerCollection get_QuestStashItem() { }

	[CompilerGenerated]
	public PlayerRecorderController get_RecorderController() { }

	public virtual CompoundItem get_Root() { }

	public override void GetAcceptableItemsNonAlloc(EquipmentSlot[] equipmentSlots, IList preAllocatedList, Predicate predicate = null, Predicate goDeeperPredicate = null) { }

	[Obsolete("Use GetReachableItemsOfTypeNonAlloc instead")]
	public IEnumerable GetReachableItemsOfType(Predicate predicate = null) { }

	public void GetReachableItemsOfTypeNonAlloc(IList preAllocatedList, Predicate predicate = null) { }

	public override void GetTraderServicesDataFromServer(string traderId) { }

	public override bool HasCultistAmulet(out CultistAmulet amulet) { }

	protected bool HasKnownMalfType(Weapon weapon) { }

	public override void InventoryCheckMagazine(Magazine magazine, bool notify) { }

	public override bool IsAllowedToSeeEquipmentSlot(Slot slot, EquipmentSlot slotName) { }

	public override bool IsAllowedToSeeSlot(Slot slot, EquipmentSlot slotName) { }

	public override bool IsAllowedToSort(CompoundItem item) { }

	public bool IsAnimatedSlot(ItemAddress itemAddress) { }

	public bool IsAtBindablePlace(Item item) { }

	public bool IsAtReachablePlace(Item item) { }

	public override bool IsInventoryBlocked() { }

	protected virtual bool IsLimitedAtAddress(string templateId, ItemAddress address, out int limit) { }

	public virtual bool IsLimitedAtAddress(Item item, ItemAddress address, out int limit) { }

	public override IResult IsRecorderEnable() { }

	protected virtual bool IsRootAddressIsStash(ItemAddress location) { }

	protected override void NotifyMagazineChecked(string name) { }

	public virtual void OnAmmoLoadedCall(int count) { }

	public virtual void OnAmmoUnloadedCall(int count) { }

	public virtual void OnMagazineCheckCall() { }

	public override void PlantTripwire(ThrowWeap grenade, PlantingKit plantingKit, Vector3 fromPosition, Vector3 toPosition, Callback callback = null) { }

	public override Task PlayStopRecorderAnimation() { }

	public override void PlayTape(TapeItem tape, RecorderItem recorder = null) { }

	public override void PlayTapeAudio(TapeItem tape, RecorderItem recorder) { }

	public override void ProcessFastWeaponSwitchAvailability() { }

	public virtual void RaiseBindItemEvent(BindItemEventArgs args) { }

	public void RaiseCriticalError() { }

	public void RaiseEvent(SetInHandsEventArgs args) { }

	public void RaiseEvent(RemoveFromHandsEventArgs args) { }

	public void RaiseEvent(FireOperationEventArgs args) { }

	public void RaiseEvent(RepairMalfunctionEventArgs args) { }

	public virtual void RaiseUnbindItemEvent(UnbindItemEventArgs args) { }

	public Task ReadChapterConditions(QuestChapter chapter, Profile profile, QuestBook quests, EChapterConditionType type) { }

	public Task ReadQuestNote(QuestNote note, Profile profile) { }

	public Task ReadQuestNoteLink(QuestNoteLink link, Profile profile) { }

	public void RechamberWeapon(Weapon weapon, Callback callback = null) { }

	[CompilerGenerated]
	public void remove_CriticalInventoryErrorHappened(Action value) { }

	[CompilerGenerated]
	public override void remove_ExamineMalfunctionEvent(Action value) { }

	[CompilerGenerated]
	public void remove_OnAmmoLoaded(Action value) { }

	[CompilerGenerated]
	public void remove_OnAmmoUnloaded(Action value) { }

	[CompilerGenerated]
	public void remove_OnCompletableItemProgressChanged(CompletableStatusDelegate value) { }

	[CompilerGenerated]
	public void remove_OnMagazineCheck(Action value) { }

	[CompilerGenerated]
	public void remove_OnProfileUpdate(Action value) { }

	public override void RemoveItem(Item item, Callback callback = null) { }

	protected void ReplaceInventory(Inventory newInventory) { }

	public void ReportProfileUpdate() { }

	[CompilerGenerated]
	private void set_Inventory(Inventory value) { }

	[CompilerGenerated]
	protected void set_RecorderController(PlayerRecorderController value) { }

	protected void SetMagazineCheckedStatus(Magazine magazine, bool status, int skill, bool useOperation = true, bool notify = true) { }

	public void SetStudyProgress(Item studyItem, float progress, EStudyState state) { }

	public override void SetupItem(Item item, string zone, Vector3 position, Quaternion rotation, float setupTime, Callback callback = null) { }

	public override void StopRecorderOperation(bool immediate, out Task completionTask) { }

	public override StudyItemBaseOperation StudyItem(CompletableItem item, RecorderItem recorder) { }

	public virtual bool TryFindItem(Func predicate, out Item result) { }

	public virtual bool TryFindItem(string itemId, out Item item) { }

	public override Task TryPurchaseTraderService(ETraderServiceType serviceType, QuestController questController, string subServiceId = null, bool simulate = false) { }

	[AsyncStateMachine(typeof(<TryPurchaseTraderServiceInternal>d__70))]
	private Task TryPurchaseTraderServiceInternal(ETraderServiceType serviceType, QuestController questController, string subServiceId = null, bool simulate = false) { }

	public void UnbindItem(EBoundItem boundItemIndex, Callback callback = null) { }

	public OperationResult UnbindItemDirect(Item item, bool simulate) { }

	[AsyncStateMachine(typeof(<UnloadAmmoInstantly>d__72`1))]
	public Task UnloadAmmoInstantly(TContainer ammoContainer, bool equipmentBlocked) { }

	public override Task UnloadMagazine(Magazine magazine, bool equipmentBlocked) { }

	[AsyncStateMachine(typeof(<UnloadSlots>d__75))]
	public Task UnloadSlots(IReadOnlyList slots, bool equipmentBlocked) { }

	public override Task UseRecorder(RecorderItem item, TapeItem tape) { }

}

