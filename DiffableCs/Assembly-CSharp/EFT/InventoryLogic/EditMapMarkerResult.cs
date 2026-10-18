namespace EFT.InventoryLogic;

public sealed class EditMapMarkerResult : ISyncOperation, IRollable, IOperationResult
{
	public readonly MapComponent Map; //Field offset: 0x10
	public readonly MapMarker Marker; //Field offset: 0x18
	public readonly int X; //Field offset: 0x20
	public readonly int Y; //Field offset: 0x24
	private readonly MapMarker _originalMarker; //Field offset: 0x28

	public EditMapMarkerResult(MapComponent map, MapMarker marker, int x, int y, MapMarker originalMarker) { }

	public override bool CanExecute(ItemController itemController) { }

	public override OperationResult Execute() { }

	public override void RaiseEvents(IItemOwner controller, CommandStatus status) { }

	public override void RollBack() { }

}

