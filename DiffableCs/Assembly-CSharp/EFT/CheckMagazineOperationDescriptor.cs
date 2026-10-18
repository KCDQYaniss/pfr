namespace EFT;

public sealed class CheckMagazineOperationDescriptor : InventoryOperationDescriptor
{
	public MongoID ItemId; //Field offset: 0x30
	public bool CheckStatus; //Field offset: 0x48
	public byte SkillLevel; //Field offset: 0x49

	public CheckMagazineOperationDescriptor() { }

	public virtual OperationCreationResult ToInventoryOperation(IPlayer player) { }

	public virtual string ToString() { }

}

