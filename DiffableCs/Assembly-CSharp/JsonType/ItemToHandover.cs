namespace JsonType;

public sealed class ItemToHandover
{
	public string id; //Field offset: 0x10
	public int count; //Field offset: 0x18

	public ItemToHandover(string itemId, int count) { }

	public ItemToHandover(Item item, int count) { }

}

