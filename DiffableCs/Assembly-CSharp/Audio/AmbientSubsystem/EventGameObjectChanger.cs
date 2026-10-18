namespace Audio.AmbientSubsystem;

public class EventGameObjectChanger : MonoBehaviour, IEventSoundContentChanger
{
	internal class EventGameObjects : SerializableEnumDictionary
	{

		public EventGameObjects() { }

	}

	[SerializeField]
	private GameObject _originalContent; //Field offset: 0x20
	[SerializeField]
	private bool _isOriginalGoEnabledByDefault; //Field offset: 0x28
	[SerializeField]
	private EventGameObjects _eventGameObjects; //Field offset: 0x30

	public EventGameObjectChanger() { }

	public void Awake() { }

	public override void ChangeSoundContent(EEventType eventType) { }

}

