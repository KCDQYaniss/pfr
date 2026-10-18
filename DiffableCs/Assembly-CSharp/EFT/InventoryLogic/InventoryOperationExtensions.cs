namespace EFT.InventoryLogic;

[Extension]
public static class InventoryOperationExtensions
{

	[Extension]
	public static bool Contains(IEnumerable limitedItems, Item item, out ItemsCount numberToDestroy) { }

	[Extension]
	public static void RollBack(IReadOnlyList operationsList) { }

	[Extension]
	public static void RollBack(IReadOnlyList operationsList) { }

	[Extension]
	public static void RollBack(IEnumerable operationsList) { }

	[Extension]
	public static void RollBack(IReadOnlyList operationsList) { }

}

