namespace Audio.AnnouncementPlayer;

public class AnnouncementEventFilterConverter : MonoBehaviour
{
	[SerializeField]
	private BaseEventFilter _triggerEventFilter; //Field offset: 0x20
	[SerializeField]
	private string _announcementId; //Field offset: 0x28

	public AnnouncementEventFilterConverter() { }

	private void Awake() { }

	private void OnDestroy() { }

	private void OnFilterPassed(BaseEventFilter filter, BaseEvent eventData) { }

}

