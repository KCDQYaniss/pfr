namespace EFT;

public struct ItemCounter
{
	private readonly int _itemsToPay; //Field offset: 0x0
	private int _itemsAvailable; //Field offset: 0x4

	public ItemCounter(int itemsToPay) { }

	public void Add(int count) { }

	public bool HasEnough() { }

}

