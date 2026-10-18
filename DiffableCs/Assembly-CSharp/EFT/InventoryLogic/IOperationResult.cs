namespace EFT.InventoryLogic;

public interface IOperationResult : IRollable
{

	public bool CanExecute(ItemController itemController) { }

	public void RaiseEvents(IItemOwner controller, CommandStatus status) { }

}

