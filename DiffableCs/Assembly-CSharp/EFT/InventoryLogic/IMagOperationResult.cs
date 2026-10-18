namespace EFT.InventoryLogic;

public interface IMagOperationResult : IOperationResult, IRollable
{

	public IOperationResult OperationResult
	{
		 get { } //Length: 0
	}

	public IOperationResult get_OperationResult() { }

}

