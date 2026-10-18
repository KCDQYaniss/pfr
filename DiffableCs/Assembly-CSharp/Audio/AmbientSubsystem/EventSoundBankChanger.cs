namespace Audio.AmbientSubsystem;

public class EventSoundBankChanger : MonoBehaviour, IEventSoundContentChanger
{
	internal class EventSoundBanks : SerializableEnumDictionary
	{

		public EventSoundBanks() { }

	}

	[SerializeField]
	private EventSoundBanks _eventSoundBanks; //Field offset: 0x20
	private ISoundBankChangeable[] _changeableComponents; //Field offset: 0x28

	public EventSoundBankChanger() { }

	private void Awake() { }

	public override void ChangeSoundContent(EEventType eventType) { }

}

