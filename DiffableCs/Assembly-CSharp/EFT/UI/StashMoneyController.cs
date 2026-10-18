namespace EFT.UI;

public class StashMoneyController : IDisposable, IAddHandler, IItemRelatedView, IRemoveHandler, IRefreshHandler
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__6_0; //Field offset: 0x8
		public static Func <>9__10_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <ContainsMoney>b__6_0(Item containedItem) { }

		internal IEnumerable <UpdateMoney>b__10_0(IContainer x) { }

	}

	private readonly DisplayMoneyPanel _moneyCountPanel; //Field offset: 0x10
	private readonly InventoryController _inventoryController; //Field offset: 0x18
	private readonly Stash _stash; //Field offset: 0x20
	private readonly Stash _sortingTable; //Field offset: 0x28

	public StashMoneyController(DisplayMoneyPanel moneyCountPanel, Stash stash, InventoryController inventoryController) { }

	private bool ContainsMoney(ContainerCollection container) { }

	public override void Dispose() { }

	private override void EFT.IAddHandler.OnItemAdded(AddItemEventArgs eventArgs) { }

	private override void EFT.IRefreshHandler.OnRefreshItem(RefreshItemEventArgs eventArgs) { }

	private override void EFT.IRemoveHandler.OnItemRemoved(RemoveItemEventArgs eventArgs) { }

	private bool IsInStash(ItemAddress address) { }

	private void UpdateMoney() { }

}

