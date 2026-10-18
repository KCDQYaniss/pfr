namespace RootMotion;

public class TriggerEventBroadcaster : MonoBehaviour
{
	public GameObject target; //Field offset: 0x20

	public TriggerEventBroadcaster() { }

	private void OnTriggerEnter(Collider collider) { }

	private void OnTriggerExit(Collider collider) { }

	private void OnTriggerStay(Collider collider) { }

}

