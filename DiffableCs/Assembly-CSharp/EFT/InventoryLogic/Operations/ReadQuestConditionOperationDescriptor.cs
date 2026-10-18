namespace EFT.InventoryLogic.Operations;

public sealed class ReadQuestConditionOperationDescriptor : InventoryOperationDescriptor
{
	public MongoID ConditionId; //Field offset: 0x30

	public ReadQuestConditionOperationDescriptor() { }

	public virtual OperationCreationResult ToInventoryOperation(IPlayer player) { }

}

