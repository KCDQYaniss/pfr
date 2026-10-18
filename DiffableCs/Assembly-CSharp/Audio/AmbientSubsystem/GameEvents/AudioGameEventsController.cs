namespace Audio.AmbientSubsystem.GameEvents;

public class AudioGameEventsController : MonoBehaviour
{
	private IEventSoundContentChanger[] _soundContentChangers; //Field offset: 0x20
	private IGameEventAudioPlayer _currentEventPlayer; //Field offset: 0x28
	private IAudioEventsFactory _eventsFactory; //Field offset: 0x30

	public AudioGameEventsController() { }

	private IGameEventAudioPlayer CreateEventPlayer(EEventType eventType) { }

	public void Init() { }

	private void OnDestroy() { }

	public void RunEvent(EEventType eventType) { }

	public void StopCurrentEvent() { }

	private void UpdateSoundContent(EEventType eventType) { }

}

