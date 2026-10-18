namespace EFT.InventoryLogic;

public sealed class PlantTripwireResult : ISyncOperation, IRollable, IOperationResult
{
	public readonly ThrowWeap Tripwire; //Field offset: 0x10
	[CanBeNull]
	public readonly PlantingKit PlantingKit; //Field offset: 0x18
	private readonly CombinedOperationResult _discardResult; //Field offset: 0x20

	public PlantTripwireResult(ThrowWeap tripwire, PlantingKit plantingKit, CombinedOperationResult discardResult) { }

	public override bool CanExecute(ItemController itemController) { }

	public override OperationResult Execute() { }

	public override void RaiseEvents(IItemOwner controller, CommandStatus status) { }

	public override void RollBack() { }

}

