namespace EFT.InventoryLogic;

public sealed class DiscardLimitsReachedError : InventoryError
{
	public const string SHORT_WARNING = "InventoryWarning/ItemsToBeDestroyed"; //Field offset: 0x0
	private const string LIMIT_REACHED_FOR_ITEM = "InventoryError/DiscardLimitReached{0}"; //Field offset: 0x0
	private const string LIMIT_REACHED_FOR_CONTAINED_ITEM = "InventoryError/DiscardLimitForContentReached{0}"; //Field offset: 0x0
	private const string LIMIT_REACHED_FOR_STACK = "InventoryError/DiscardLimitForStackReached"; //Field offset: 0x0
	private const string FULL_DESCRIPTION = "InventoryWarning/ItemsWillBeDestroyed"; //Field offset: 0x0
	private readonly Item _item; //Field offset: 0x10
	public readonly IEnumerable LimitedItems; //Field offset: 0x18

	public DiscardLimitsReachedError(Item item, IEnumerable limitedItems) { }

	public static string GetFullLocalizedDescription(IEnumerable limitedItems) { }

	public virtual string GetLocalizedDescription() { }

	public virtual string ToString() { }

}

