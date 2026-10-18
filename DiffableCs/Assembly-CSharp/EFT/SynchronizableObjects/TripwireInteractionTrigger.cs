namespace EFT.SynchronizableObjects;

public sealed class TripwireInteractionTrigger : MonoBehaviour, IInteractive
{
	[SerializeField]
	private TripwireSynchronizableObject _tripwireSynchronizable; //Field offset: 0x20

	public TripwireSynchronizableObject Tripwire
	{
		 get { } //Length: 5
	}

	public TripwireInteractionTrigger() { }

	public bool DistanceCheck(Vector3 position) { }

	public TripwireSynchronizableObject get_Tripwire() { }

}

