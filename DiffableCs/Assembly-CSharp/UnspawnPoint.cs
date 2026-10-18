//Type is in global namespace

public class UnspawnPoint : MonoBehaviour, IPositionPoint
{

	public override Vector3 Position
	{
		 get { } //Length: 204
	}

	public UnspawnPoint() { }

	public override Vector3 get_Position() { }

	private void OnDrawGizmosSelected() { }

}

