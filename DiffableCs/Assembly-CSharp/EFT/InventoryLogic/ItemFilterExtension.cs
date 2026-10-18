namespace EFT.InventoryLogic;

[Extension]
public static class ItemFilterExtension
{

	[Extension]
	public static bool CanAccept(IContainer container, Item item) { }

	private static bool CheckItem(ItemFilter[] filters, Item item, bool checkOnlyExclusive) { }

	[Extension]
	public static bool CheckItemExcludedFilter(ItemFilter[] filters, Item item) { }

	[Extension]
	public static bool CheckItemFilter(ItemFilter[] filters, Item item) { }

}

