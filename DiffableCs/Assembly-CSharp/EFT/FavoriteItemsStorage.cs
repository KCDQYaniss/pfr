namespace EFT;

public sealed class FavoriteItemsStorage : HashSet
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public CompoundItem stashItem; //Field offset: 0x10

		public <>c__DisplayClass4_0() { }

		internal bool <GetAllStashes>b__0(CompoundItem s) { }

	}

	public readonly BindableEvent OnFavoriteItemsChanged; //Field offset: 0x48

	public FavoriteItemsStorage(List items) { }

	[CompilerGenerated]
	private int <GetItemsCount>b__3_0(CompoundItem stashItem) { }

	[CompilerGenerated]
	private bool <GetItemsCount>b__3_1(Item item) { }

	private bool AddItemToFavorites(Item item) { }

	public bool CanAddItem(Item item, Inventory inventory, out string error) { }

	private IEnumerable GetAllStashes(Inventory inventory, string parentId, out EAreaType areaType) { }

	private string GetErrorText(int maxItemsCount, EAreaType areaType) { }

	private void GetItemsCount(Inventory inventory, string parentId, out int currentItemsCount, out int maxItemsCount, out string error) { }

	private static int GetMaxItemsCount(EAreaType areaType) { }

	public bool RemoveItemFromFavorites(Item item) { }

	public bool TryAddItemToFavorites(Item item, Inventory inventory) { }

}

