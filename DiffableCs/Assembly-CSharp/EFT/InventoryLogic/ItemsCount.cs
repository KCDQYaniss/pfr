namespace EFT.InventoryLogic;

[IsReadOnly]
public struct ItemsCount
{
	public readonly Item Item; //Field offset: 0x0
	public readonly int NumberToDestroy; //Field offset: 0x8
	public readonly int NumberToPreserve; //Field offset: 0xC

	public ItemsCount(Item item, int numberToDestroy, int numberToPreserve) { }

	public DestroyedItem Data() { }

	public void Deconstruct(out Item item, out int numberToDestroy) { }

	public void Deconstruct(out Item item, out int numberToDestroy, out int numberToPreserve) { }

	public virtual string ToString() { }

}

