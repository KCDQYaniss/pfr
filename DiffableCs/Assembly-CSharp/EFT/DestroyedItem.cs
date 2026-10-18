namespace EFT;

[BinaryReaderCompatible("ReadDestroyedItem", "WriteDestroyedItem")]
[IsReadOnly]
[JsonObject(MemberSerialization::OptIn (1))]
public struct DestroyedItem
{
	[JsonProperty("id")]
	public readonly MongoID ItemId; //Field offset: 0x0
	[JsonProperty("count")]
	public readonly int NumberToDestroy; //Field offset: 0x18
	public readonly int NumberToPreserve; //Field offset: 0x1C

	public DestroyedItem(MongoID itemId, int numberToDestroy, int numberToPreserve) { }

	public DestroyedItem(ItemsCount itemsCount) { }

	[JsonConstructor]
	private DestroyedItem(MongoID itemId, int numberToDestroy) { }

	public void Deconstruct(out string itemId, out int numberToDestroy, out int numberToPreserve) { }

}

