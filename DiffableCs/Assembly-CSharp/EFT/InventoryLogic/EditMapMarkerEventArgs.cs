namespace EFT.InventoryLogic;

public sealed class EditMapMarkerEventArgs : ItemEventArgs
{
	public readonly int X; //Field offset: 0x40
	public readonly int Y; //Field offset: 0x44
	public readonly MapComponent Map; //Field offset: 0x48
	public readonly MapMarker MapMarker; //Field offset: 0x50

	public EditMapMarkerEventArgs(MapComponent map, int x, int y, MapMarker mapMarker, CommandStatus status, IItemOwner owner) { }

}

