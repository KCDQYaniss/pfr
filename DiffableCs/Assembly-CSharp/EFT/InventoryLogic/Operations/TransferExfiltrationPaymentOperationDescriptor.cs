namespace EFT.InventoryLogic.Operations;

public sealed class TransferExfiltrationPaymentOperationDescriptor : InventoryOperationDescriptor
{
	public string PointName; //Field offset: 0x30
	public DestroyedItem[] Items; //Field offset: 0x38

	public TransferExfiltrationPaymentOperationDescriptor() { }

	[CompilerGenerated]
	private bool <ToInventoryOperation>b__2_0(ExfiltrationPoint x) { }

	public virtual OperationCreationResult ToInventoryOperation(IPlayer player) { }

	public virtual string ToString() { }

}

