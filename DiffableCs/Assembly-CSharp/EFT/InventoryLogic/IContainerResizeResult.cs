namespace EFT.InventoryLogic;

public interface IContainerResizeResult : IOperationResult, IRollable
{

	public bool IsRealResize
	{
		 get { } //Length: 0
	}

	public bool get_IsRealResize() { }

}

