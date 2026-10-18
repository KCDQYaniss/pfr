namespace EFT.InventoryLogic;

public sealed class LoadMagazineEventArgs : ItemEventArgs, ISingleEventArgs
{
	public readonly Item TargetItem; //Field offset: 0x40
	public readonly float LoadTime; //Field offset: 0x48
	public readonly int LoadCount; //Field offset: 0x4C

	public LoadMagazineEventArgs(Item item, Item targetItem, int loadCount, float loadTime, CommandStatus status, IItemOwner owner) { }

}

