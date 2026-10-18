namespace Audio.AmbientSubsystem;

public class EventTimeDependentSoundChanger : MonoBehaviour, IEventSoundContentChanger
{
	[SerializeField]
	private DayTimeAmbientSoundContainer _soundContainer; //Field offset: 0x20
	private IDayTimeSoundContainerChangeable[] _changeableComponents; //Field offset: 0x28

	public EventTimeDependentSoundChanger() { }

	private void Awake() { }

	public override void ChangeSoundContent(EEventType eventType) { }

}

