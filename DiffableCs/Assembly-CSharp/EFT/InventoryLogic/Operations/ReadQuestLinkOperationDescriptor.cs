namespace EFT.InventoryLogic.Operations;

public sealed class ReadQuestLinkOperationDescriptor : InventoryOperationDescriptor
{
	public MongoID LinkId; //Field offset: 0x30

	public ReadQuestLinkOperationDescriptor() { }

	public virtual OperationCreationResult ToInventoryOperation(IPlayer player) { }

}

