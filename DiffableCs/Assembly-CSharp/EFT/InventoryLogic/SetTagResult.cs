namespace EFT.InventoryLogic;

public sealed class SetTagResult : ISyncOperation, IRollable, IOperationResult
{
	public readonly TagComponent Tag; //Field offset: 0x10
	public readonly string Name; //Field offset: 0x18
	public readonly int Color; //Field offset: 0x20
	private readonly string _oldName; //Field offset: 0x28
	private readonly int _oldColor; //Field offset: 0x30

	internal SetTagResult(TagComponent tag, string name, int color, string oldName, int oldColor) { }

	public override bool CanExecute(ItemController itemController) { }

	public override OperationResult Execute() { }

	public override void RaiseEvents(IItemOwner controller, CommandStatus status) { }

	public override void RollBack() { }

}

