namespace Audio.AmbientSubsystem;

public class EventAudioClipChanger : MonoBehaviour, IEventSoundContentChanger
{
	internal class EventAudioClips : SerializableEnumDictionary
	{

		public EventAudioClips() { }

	}

	[SerializeField]
	private EventAudioClips _eventAudioClips; //Field offset: 0x20
	private IAudioClipChangeable[] _changeableComponents; //Field offset: 0x28

	public EventAudioClipChanger() { }

	private void Awake() { }

	public override void ChangeSoundContent(EEventType eventType) { }

}

