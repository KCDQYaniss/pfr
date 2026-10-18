namespace EFT.InventoryLogic;

public sealed class ToggleResult : ISyncOperation, IRollable, IOperationResult
{
	public readonly TogglableComponent Togglable; //Field offset: 0x10
	private readonly bool _newValue; //Field offset: 0x18

	public ToggleResult(TogglableComponent togglable, bool newValue) { }

	public override bool CanExecute(ItemController itemController) { }

	public override OperationResult Execute() { }

	public override void RaiseEvents(IItemOwner controller, CommandStatus status) { }

	public override void RollBack() { }

}

