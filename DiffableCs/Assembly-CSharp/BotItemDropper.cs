//Type is in global namespace

public class BotItemDropper : BotData
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public Item itemToDrop; //Field offset: 0x10
		public BotItemDropper <>4__this; //Field offset: 0x18

		public <>c__DisplayClass14_0() { }

		internal void <TryDoDrop>b__0(IResult result) { }

	}

	private const float POSSIBLE_DROP_ITEM_PERIOD_SEC = 3; //Field offset: 0x0
	private readonly List itemsListCache; //Field offset: 0x18
	private Item _itemToDropNext; //Field offset: 0x20
	private float _nextTimeDrop; //Field offset: 0x28
	private readonly HashSet _possibleItemsTIdsToDrop; //Field offset: 0x30
	private readonly List _itemsToDropCache; //Field offset: 0x38
	[CompilerGenerated]
	private Action OnItemDrop; //Field offset: 0x40

	public event Action OnItemDrop
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public BotItemDropper(BotOwner owner) { }

	public void Activate() { }

	[CompilerGenerated]
	public void add_OnItemDrop(Action value) { }

	public void RefreshItemToDrop() { }

	[CompilerGenerated]
	public void remove_OnItemDrop(Action value) { }

	public void SetItemToDropNext(Item item) { }

	public void SetItemToDropNext(string itemId) { }

	public void TryDoDrop() { }

}

