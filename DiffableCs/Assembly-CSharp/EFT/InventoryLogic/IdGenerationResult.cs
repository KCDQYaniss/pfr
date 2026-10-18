namespace EFT.InventoryLogic;

public sealed class IdGenerationResult : IOperationResult, IRollable
{
	private readonly IDatabaseIdGenerator _idGenerator; //Field offset: 0x10

	public IdGenerationResult(IDatabaseIdGenerator idGenerator) { }

	public override bool CanExecute(ItemController itemController) { }

	public override void RaiseEvents(IItemOwner controller, CommandStatus status) { }

	public override void RollBack() { }

}

