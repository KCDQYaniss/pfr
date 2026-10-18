//Type is in global namespace

public class BotItemTaker : BotData
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_0
	{
		public IOperationResult possibleAction; //Field offset: 0x10
		public IPlayer lootItemLastOwner; //Field offset: 0x18
		public Player owner; //Field offset: 0x20
		public Item rootItem; //Field offset: 0x28
		public BotItemTaker <>4__this; //Field offset: 0x30
		public Callback <>9__1; //Field offset: 0x38

		public <>c__DisplayClass27_0() { }

		internal void <PickupAction>b__0() { }

		internal void <PickupAction>b__1(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass38_0
	{
		public BotItemTaker <>4__this; //Field offset: 0x10
		public LootItem item; //Field offset: 0x18

		public <>c__DisplayClass38_0() { }

		internal void <OnThrowItem>b__0() { }

	}

	private const float DIST_TO_TAKE = 1.5; //Field offset: 0x0
	private const float LOOK_PERIOD = 1.5; //Field offset: 0x0
	private const float PERIOD_REFRESH_IF_NO_PLACE = 60; //Field offset: 0x0
	private const float SDIST_TO_TAKE = 2.25; //Field offset: 0x0
	private const float DIR_UPDATE_PERIOD = 2; //Field offset: 0x0
	private readonly HashSet _thrownItems; //Field offset: 0x18
	private readonly HashSet _preThrownItems; //Field offset: 0x20
	private LootItem _itemToTake; //Field offset: 0x28
	private bool _isCome; //Field offset: 0x30
	private float _timeToTake; //Field offset: 0x34
	private float _nextTimeToTake; //Field offset: 0x38
	private float _nextRefreshTime; //Field offset: 0x3C
	private bool canPickUpMeds; //Field offset: 0x40
	private bool canPickUpWeapons; //Field offset: 0x41
	private Vector3 dir; //Field offset: 0x44
	private float _prevDirUpdateTime; //Field offset: 0x50
	[CompilerGenerated]
	private Action OnItemTaken; //Field offset: 0x58

	public event Action OnItemTaken
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	private BotGlobalsMindSettings Mind
	{
		private get { } //Length: 45
	}

	public BotItemTaker(BotOwner owner) { }

	public void Activate() { }

	[CompilerGenerated]
	public void add_OnItemTaken(Action value) { }

	private bool CanFindWay(Vector3 transformPosition) { }

	public void Dispose() { }

	private BotGlobalsMindSettings get_Mind() { }

	private void GetAvailableInteractionState(LootItem item) { }

	private ItemAddress GetItemAddress(Item item) { }

	public bool HaveItemToTake() { }

	private bool HaveSpace(LootItem thrownItem) { }

	private void LookAndTakeItem() { }

	public void ManualUpdate() { }

	private void MoveTo(Vector3 position) { }

	private void OnTakeItem(LootItem item) { }

	private void OnThrowItem(LootItem item) { }

	private void PickupAction(Player owner, IOperationResult possibleAction, Item rootItem, IPlayer lootItemLastOwner) { }

	public void RefreshClosestItems() { }

	[CompilerGenerated]
	public void remove_OnItemTaken(Action value) { }

	private void RemoveLootItem(LootItem item) { }

	private bool SomebodyTargetItem(LootItem throwedItem) { }

	private void Take(LootItem itemToTake) { }

	private bool TryPlaceToContainerInSlot(EquipmentSlot slot, LootItem item) { }

}

