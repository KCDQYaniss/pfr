namespace EFT.InventoryLogic;

public sealed class CreateMapMarkerResult : ISyncOperation, IRollable, IOperationResult
{
	public readonly MapComponent Map; //Field offset: 0x10
	public readonly MapMarker Marker; //Field offset: 0x18

	public CreateMapMarkerResult(MapComponent map, MapMarker marker) { }

	public override bool CanExecute(ItemController itemController) { }

	public override OperationResult Execute() { }

	public override void RaiseEvents(IItemOwner controller, CommandStatus status) { }

	public override void RollBack() { }

}

