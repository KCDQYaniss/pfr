namespace EFT;

public sealed class PlantTripwireOperationDescriptor : InventoryOperationDescriptor
{
	public MongoID TripwireId; //Field offset: 0x30
	public Nullable PlantingKitId; //Field offset: 0x48
	public ClassVector3 FromPosition; //Field offset: 0x68
	public ClassVector3 ToPosition; //Field offset: 0x70

	public PlantTripwireOperationDescriptor() { }

	public virtual OperationCreationResult ToInventoryOperation(IPlayer player) { }

	public virtual string ToString() { }

}

