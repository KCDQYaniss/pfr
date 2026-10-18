namespace EFT.InventoryLogic;

public sealed class CreateMapMarkerEventArgs : ItemEventArgs
{
	public readonly MapComponent Map; //Field offset: 0x40
	public readonly MapMarker MapMarker; //Field offset: 0x48

	public CreateMapMarkerEventArgs(MapComponent map, MapMarker mapMarker, CommandStatus status, IItemOwner owner) { }

}

