namespace EFT.InventoryLogic;

public sealed class DeleteMapMarkerEventArgs : ItemEventArgs
{
	public readonly MapComponent Map; //Field offset: 0x40
	public readonly int X; //Field offset: 0x48
	public readonly int Y; //Field offset: 0x4C

	public DeleteMapMarkerEventArgs(MapComponent map, int x, int y, CommandStatus status, IItemOwner owner) { }

}

