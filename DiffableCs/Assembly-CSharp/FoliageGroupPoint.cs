//Type is in global namespace

public class FoliageGroupPoint
{
	public GroupPoint Point; //Field offset: 0x10
	public NavTriangle Triangle; //Field offset: 0x18

	public Vector3 Position
	{
		 get { } //Length: 41
	}

	public FoliageGroupPoint(GroupPoint point, NavTriangle triangle) { }

	public Vector3 get_Position() { }

}

