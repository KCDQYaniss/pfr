namespace EFT;

public sealed class EditMapMarkerOperationDescriptor : InventoryOperationDescriptor
{
	public string MapItemId; //Field offset: 0x30
	public int X; //Field offset: 0x38
	public int Y; //Field offset: 0x3C
	public MapMarker MapMarker; //Field offset: 0x40

	public EditMapMarkerOperationDescriptor() { }

	public virtual OperationCreationResult ToInventoryOperation(IPlayer player) { }

	public virtual string ToString() { }

}

