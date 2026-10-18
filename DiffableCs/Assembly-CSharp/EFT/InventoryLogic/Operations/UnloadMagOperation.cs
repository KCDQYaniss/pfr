namespace EFT.InventoryLogic.Operations;

public sealed class UnloadMagOperation : AbstractMagOperation
{

	public UnloadMagOperation(ushort id, ItemController controller, AbstractOperation internalOperation) { }

	protected virtual void SucceedAmmoManipulationHandler() { }

}

