namespace EFT;

public sealed class DeleteMapMarkerOperationDescriptor : InventoryOperationDescriptor
{
	public string MapItemId; //Field offset: 0x30
	public int X; //Field offset: 0x38
	public int Y; //Field offset: 0x3C

	public DeleteMapMarkerOperationDescriptor() { }

	public virtual OperationCreationResult ToInventoryOperation(IPlayer player) { }

	public virtual string ToString() { }

}

