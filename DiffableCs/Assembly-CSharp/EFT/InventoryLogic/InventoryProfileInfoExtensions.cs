namespace EFT.InventoryLogic;

[Extension]
public static class InventoryProfileInfoExtensions
{

	[Extension]
	public static bool IsCompletableItemCompleted(IInventoryProfileInfo source, CompletableItem item) { }

	[Extension]
	public static bool IsCompletableItemCompleted(IInventoryProfileInfo source, MongoID templateId) { }

	[Extension]
	public static bool IsCompletableItemFound(IInventoryProfileInfo source, CompletableItem item) { }

	[Extension]
	public static bool IsCompletableItemFound(IInventoryProfileInfo source, MongoID templateId) { }

}

