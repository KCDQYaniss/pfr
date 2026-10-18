namespace EFT.Vaulting.Models;

public interface IGridRootMoverModel
{

	public float AbsoluteForwardVelocity
	{
		 get { } //Length: 0
	}

	public float get_AbsoluteForwardVelocity() { }

	public void RecalculateGridOffset(GridRootMoverTransferModel data) { }

}

