namespace EFT.Vaulting.Models;

public class GridRootMoverModel : IGridRootMoverModel, IGridRootMoverModelDebug
{
	private readonly Transform _gridRoot; //Field offset: 0x10
	private Vector3 _currentVelocity; //Field offset: 0x18

	public override float AbsoluteForwardVelocity
	{
		 get { } //Length: 9
	}

	public GridRootMoverModel(Transform gridRoot) { }

	private Vector3 CalculateVelocityProjection(Vector3 playerRealForward, Vector3 projection) { }

	public override float get_AbsoluteForwardVelocity() { }

	public override void RecalculateGridOffset(GridRootMoverTransferModel data) { }

}

