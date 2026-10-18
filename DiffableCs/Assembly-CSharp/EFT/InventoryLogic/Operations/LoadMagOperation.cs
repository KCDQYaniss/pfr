namespace EFT.InventoryLogic.Operations;

public sealed class LoadMagOperation : AbstractMagOperation
{

	public LoadMagOperation(ushort id, ItemController controller, AbstractOperation internalOperation) { }

	protected virtual void SucceedAmmoManipulationHandler() { }

}

