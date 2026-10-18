//Type is in global namespace

public class SpecificDoorStateChangeEventGenerator : MonoBehaviour
{
	[SerializeField]
	private Door _targetDoor; //Field offset: 0x20

	public SpecificDoorStateChangeEventGenerator() { }

	private void Awake() { }

	private void OnDestroy() { }

	private void OnDoorStateChanged(WorldInteractiveObject obj, EDoorState prevState, EDoorState nextState) { }

}

