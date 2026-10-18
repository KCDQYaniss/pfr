namespace EFT.InventoryLogic;

public sealed class UnknownItemError : InventoryError
{
	private const string UNKNOWN_ITEM = "InventoryError/UnknownItemManipulation"; //Field offset: 0x0
	private readonly Item _item; //Field offset: 0x10
	private readonly EObserverItemState _state; //Field offset: 0x18

	public UnknownItemError(Item item, EObserverItemState state) { }

	public virtual string GetLocalizedDescription() { }

	public virtual string ToString() { }

}

