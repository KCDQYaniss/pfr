//Type is in global namespace

public interface IPointPatrol
{

	public bool HaveLookSide
	{
		 get { } //Length: 0
	}

	public int LookIndexes
	{
		 get { } //Length: 0
	}

	public Vector3 Position
	{
		 get { } //Length: 0
	}

	public bool get_HaveLookSide() { }

	public int get_LookIndexes() { }

	public Vector3 get_Position() { }

	public int GetOwnerId() { }

	public Vector3 LookDir(int index) { }

	public void SetOwner(BotOwner owner) { }

}

