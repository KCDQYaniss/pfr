//Type is in global namespace

public class PatrolPointContainer
{
	public PatrolPoint TargetPoint; //Field offset: 0x10

	public AReserveWayAction ActionData
	{
		 get { } //Length: 27
	}

	public int Id
	{
		 get { } //Length: 26
	}

	public Vector3 Position
	{
		 get { } //Length: 59
	}

	public PatrolPointContainer(PatrolPoint TargetPoint) { }

	public AReserveWayAction get_ActionData() { }

	public int get_Id() { }

	public Vector3 get_Position() { }

	public PatrolPoint GetSubPoint(int index) { }

}

