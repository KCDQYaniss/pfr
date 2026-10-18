namespace EFT.InventoryLogic;

public sealed class ExamineItemEventArgs : ItemEventArgs
{
	public readonly float ExamineTime; //Field offset: 0x40

	public ExamineItemEventArgs(Item item, float examineTime, CommandStatus status, IItemOwner owner) { }

}

