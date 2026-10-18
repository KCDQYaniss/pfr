namespace EFT;

public sealed class CreateMapMarkerOperationDescriptor : InventoryOperationDescriptor
{
	public string MapItemId; //Field offset: 0x30
	public MapMarker MapMarker; //Field offset: 0x38

	public CreateMapMarkerOperationDescriptor() { }

	public virtual OperationCreationResult ToInventoryOperation(IPlayer player) { }

	public virtual string ToString() { }

}

