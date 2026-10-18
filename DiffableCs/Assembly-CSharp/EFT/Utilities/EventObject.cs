namespace EFT.Utilities;

public sealed class EventObject : MonoBehaviour
{
	[SerializeField]
	private EEventType _eventType; //Field offset: 0x20
	[SerializeField]
	private EMissingEventActionType _eventAction; //Field offset: 0x24

	private bool EventFound
	{
		private get { } //Length: 195
	}

	public EventObject() { }

	private bool get_EventFound() { }

	private void OnEnable() { }

}

