namespace EFT.Interactive;

public class EventObjectInteractive : MonoBehaviour, IInteractive
{
	[SerializeField]
	private EventObject _object; //Field offset: 0x20

	public int Id
	{
		 get { } //Length: 26
	}

	public EventObjectInteractive() { }

	public bool DistanceCheck(Vector3 position) { }

	public int get_Id() { }

}

