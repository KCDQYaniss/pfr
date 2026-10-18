namespace EFT;

public sealed class StudyItemPlayerOperationDescriptor : StudyItemOperationDescriptor
{
	public Nullable RecorderId; //Field offset: 0x48

	public StudyItemPlayerOperationDescriptor() { }

	public virtual OperationCreationResult ToInventoryOperation(IPlayer player) { }

	public virtual string ToString() { }

}

