//Type is in global namespace

public interface INetPoint
{

	public int Id
	{
		 get { } //Length: 0
	}

	public Vector3 Position
	{
		 get { } //Length: 0
	}

	public void AddWay(int id, INetPoint wayTo) { }

	public void ClearConnections() { }

	public int get_Id() { }

	public Vector3 get_Position() { }

}

