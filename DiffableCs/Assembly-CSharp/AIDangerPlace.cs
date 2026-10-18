//Type is in global namespace

public class AIDangerPlace : IPositionPoint
{
	[SerializeField]
	private Vector3 _pos; //Field offset: 0x10

	public override Vector3 Position
	{
		 get { } //Length: 19
	}

	public AIDangerPlace() { }

	public override Vector3 get_Position() { }

	public void SetPos(Vector3 p) { }

}

