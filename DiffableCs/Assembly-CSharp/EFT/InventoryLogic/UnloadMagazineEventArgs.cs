namespace EFT.InventoryLogic;

public sealed class UnloadMagazineEventArgs : ItemEventArgs, ISingleEventArgs
{
	public readonly Item TargetItem; //Field offset: 0x40
	public readonly Magazine FromItem; //Field offset: 0x48
	public readonly float UnloadTime; //Field offset: 0x50
	public readonly int UnloadCount; //Field offset: 0x54
	public readonly int StartCount; //Field offset: 0x58

	public UnloadMagazineEventArgs(Item item, Item targetItem, Magazine fromItem, int startCount, int unloadCount, float unloadTime, CommandStatus status, IItemOwner owner) { }

}

