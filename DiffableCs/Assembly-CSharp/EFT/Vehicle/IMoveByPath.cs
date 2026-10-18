namespace EFT.Vehicle;

public interface IMoveByPath
{

	public PathSpline CurrentPath
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public PathSpline get_CurrentPath() { }

	public void set_CurrentPath(PathSpline value) { }

}

