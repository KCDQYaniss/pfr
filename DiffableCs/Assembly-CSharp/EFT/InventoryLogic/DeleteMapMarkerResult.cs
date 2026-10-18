namespace EFT.InventoryLogic;

public sealed class DeleteMapMarkerResult : ISyncOperation, IRollable, IOperationResult
{
	public readonly MapComponent Map; //Field offset: 0x10
	public readonly int X; //Field offset: 0x18
	public readonly int Y; //Field offset: 0x1C
	private readonly MapMarker _deletedMarker; //Field offset: 0x20

	internal DeleteMapMarkerResult(MapComponent map, int x, int y, MapMarker deletedMarker) { }

	public override bool CanExecute(ItemController itemController) { }

	public override OperationResult Execute() { }

	public override void RaiseEvents(IItemOwner controller, CommandStatus status) { }

	public override void RollBack() { }

}

