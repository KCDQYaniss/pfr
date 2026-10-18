namespace EFT.Vaulting.Models;

public interface IGridPointsModelDebug : IGridPointsModel
{

	public List FrontFromPositions
	{
		 get { } //Length: 0
	}

	public Vector3 GridRootPosition
	{
		 get { } //Length: 0
	}

	public List TopFromPositions
	{
		 get { } //Length: 0
	}

	public List get_FrontFromPositions() { }

	public Vector3 get_GridRootPosition() { }

	public List get_TopFromPositions() { }

}

