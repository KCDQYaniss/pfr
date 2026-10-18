namespace EFT.InventoryLogic;

public sealed class LoadMagOperationResult : AbstractMagOperationResult, ILoadMagOperationResult, IMagOperationResult, IOperationResult, IRollable
{

	public LoadMagOperationResult(ISyncOperationResult operationResult) { }

	public static OperationResult op_Implicit(LoadMagOperationResult loadMegResult) { }

}

