namespace EFT.InventoryLogic;

public sealed class DiscardLimitsDesyncError : InventoryError
{
	private readonly Item _unexpectedItem; //Field offset: 0x10
	private readonly int _expectedCount; //Field offset: 0x18
	private readonly int _foundCount; //Field offset: 0x1C

	public DiscardLimitsDesyncError(Item unexpectedItem, int expectedCount, int foundCount) { }

	public virtual string ToString() { }

}

