namespace EFT;

public abstract class QuestActionDescriptor : InventoryOperationDescriptor
{
	public string QuestId; //Field offset: 0x30

	protected QuestActionDescriptor() { }

	public virtual OperationCreationResult ToInventoryOperation(IPlayer player) { }

	protected abstract OperationCreationResult ToQuestOperation(Player player) { }

}

