namespace EFT.InventoryLogic;

public sealed class RecodeResult : ISyncOperation, IRollable, IOperationResult
{
	public readonly RecodableComponent Recodable; //Field offset: 0x10
	public readonly bool NewValue; //Field offset: 0x18
	private readonly string _profileId; //Field offset: 0x20

	public RecodeResult(RecodableComponent recodable, bool newValue, string profileId) { }

	public override bool CanExecute(ItemController itemController) { }

	public override OperationResult Execute() { }

	public override void RaiseEvents(IItemOwner controller, CommandStatus status) { }

	public override void RollBack() { }

}

